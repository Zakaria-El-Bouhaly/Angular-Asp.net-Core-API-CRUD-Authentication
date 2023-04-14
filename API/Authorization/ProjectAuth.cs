using Colab.Repositories;
using Colab.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace Colab.Authorization
{
    public class ProjectAuth : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly string[] _roles;
        private readonly IProjectRepo _projectRepo;
        private readonly ITokenService _tokensService;

        public ProjectAuth(IProjectRepo projectRepo, ITokenService tokensService, params string[] roles)
        {
            _roles = roles;
            _projectRepo = projectRepo;
            _tokensService = tokensService;
        }

        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            // Check if the user is authenticated
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new ForbidResult();
                return;
            }

            // Check if the user has one of the allowed roles
            bool isAuthorized = _roles.Any(role => context.HttpContext.User.IsInRole(role));
            if (!isAuthorized)
            {
                context.Result = new ForbidResult();
                return;
            }

            // Check if the user is an admin
            bool isAdmin = context.HttpContext.User.IsInRole("Admin");
            if (isAdmin)
            {
                return;
            }

            // Check if the user is the owner of the project
            if (context.HttpContext.Request.RouteValues.TryGetValue("id", out var projectIdObject))
            {
                if (projectIdObject is string projectIdString && int.TryParse(projectIdString, out var projectId))
                {
                    // Check if the user is the owner of the project
                    if (await _projectRepo.isOnwerOfProject(projectId, int.Parse(context.HttpContext.User.Identity.Name)) == false)
                    {
                        return;
                    }
                }
            }


            context.Result = new ForbidResult();
        }
    }
}