using Colab.Models;
using Colab.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Colab.Repositories;
using Colab.config;

var builder = WebApplication.CreateBuilder(args);

//add dbcontext
builder.Services.AddDbContext<MainDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProjectRepo, ProjectRepo>();
builder.Services.AddScoped<IAssignmentRepo, AssignmentRepo>();
builder.Services.AddScoped<IProfileRepo, ProfileRepo>();
builder.Services.AddScoped<IInvitationRepo, InvitRepo>();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

//add jwt authorization
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });



// add identity
builder.Services.AddHttpClient();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdminRole", p => p.RequireRole("Admin"));
    options.AddPolicy("RequireUserRole", p => p.RequireRole("User"));
});

// add httpcontext
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<ITokenService, JwtService>();
builder.Services.AddScoped<IEmailService, EmailService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// add authorization to swagger jwt bearer
builder.Services.AddSwaggerGen();

//config mailkit
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection(nameof(MailSettings)));

// add log file
builder.Logging.AddFile("Logs/colab-{Date}.txt");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// enable autorization token bearer in swagger
app.UseHttpsRedirection();

//serve files 
app.UseStaticFiles();


// use cors to allow all origins
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();