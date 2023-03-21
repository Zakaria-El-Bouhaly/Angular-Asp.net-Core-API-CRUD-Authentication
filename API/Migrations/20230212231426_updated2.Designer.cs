﻿// <auto-generated />
using System;
using Colab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Colab.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230212231426_updated2")]
    partial class updated2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Colab.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 11, 21, 13, 49, 16, 762, DateTimeKind.Local).AddTicks(6143),
                            Description = "Fuga ducimus enim mo",
                            IsCompleted = false,
                            ProjectId = 9,
                            Title = "Refined Metal Towels",
                            UpdatedAt = new DateTime(2022, 8, 3, 11, 29, 42, 414, DateTimeKind.Local).AddTicks(3472)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 9, 15, 16, 14, 38, 57, DateTimeKind.Local).AddTicks(6136),
                            Description = "Quidem molestias off",
                            IsCompleted = false,
                            ProjectId = 3,
                            Title = "Practical Granite Shoes",
                            UpdatedAt = new DateTime(2022, 11, 27, 16, 21, 6, 415, DateTimeKind.Local).AddTicks(3209)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 1, 27, 5, 45, 36, 9, DateTimeKind.Local).AddTicks(366),
                            Description = "Quo omnis fugit est ",
                            IsCompleted = false,
                            ProjectId = 1,
                            Title = "Licensed Metal Computer",
                            UpdatedAt = new DateTime(2023, 1, 30, 11, 53, 57, 6, DateTimeKind.Local).AddTicks(7815)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 9, 30, 21, 31, 21, 580, DateTimeKind.Local).AddTicks(8238),
                            Description = "Qui qui provident ei",
                            IsCompleted = false,
                            ProjectId = 6,
                            Title = "Tasty Plastic Computer",
                            UpdatedAt = new DateTime(2022, 4, 30, 5, 56, 33, 219, DateTimeKind.Local).AddTicks(8680)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 1, 20, 7, 28, 50, 217, DateTimeKind.Local).AddTicks(1659),
                            Description = "Quos molestiae autem",
                            IsCompleted = false,
                            ProjectId = 10,
                            Title = "Fantastic Concrete Shoes",
                            UpdatedAt = new DateTime(2022, 9, 30, 8, 25, 40, 226, DateTimeKind.Local).AddTicks(2987)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 2, 23, 9, 16, 417, DateTimeKind.Local).AddTicks(9129),
                            Description = "Iure et et dicta rep",
                            IsCompleted = false,
                            ProjectId = 8,
                            Title = "Refined Wooden Chicken",
                            UpdatedAt = new DateTime(2022, 10, 29, 1, 7, 20, 625, DateTimeKind.Local).AddTicks(3939)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 9, 14, 18, 7, 46, 958, DateTimeKind.Local).AddTicks(9055),
                            Description = "Velit et velit nostr",
                            IsCompleted = false,
                            ProjectId = 5,
                            Title = "Small Fresh Shirt",
                            UpdatedAt = new DateTime(2022, 5, 2, 10, 52, 15, 228, DateTimeKind.Local).AddTicks(8196)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 3, 11, 19, 29, 21, 371, DateTimeKind.Local).AddTicks(7727),
                            Description = "Eius voluptatem quis",
                            IsCompleted = false,
                            ProjectId = 3,
                            Title = "Licensed Metal Car",
                            UpdatedAt = new DateTime(2022, 8, 17, 1, 18, 16, 433, DateTimeKind.Local).AddTicks(8297)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 6, 11, 15, 15, 37, 941, DateTimeKind.Local).AddTicks(7841),
                            Description = "Adipisci excepturi m",
                            IsCompleted = false,
                            ProjectId = 9,
                            Title = "Gorgeous Plastic Car",
                            UpdatedAt = new DateTime(2022, 10, 14, 6, 27, 55, 87, DateTimeKind.Local).AddTicks(801)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2023, 1, 14, 12, 6, 50, 832, DateTimeKind.Local).AddTicks(3920),
                            Description = "Aut hic placeat reic",
                            IsCompleted = false,
                            ProjectId = 4,
                            Title = "Handmade Concrete Sausages",
                            UpdatedAt = new DateTime(2022, 8, 6, 15, 55, 50, 677, DateTimeKind.Local).AddTicks(6147)
                        });
                });

            modelBuilder.Entity("Colab.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 4, 18, 12, 4, 55, 417, DateTimeKind.Local).AddTicks(4859),
                            Description = "Voluptatem sit volup",
                            OwnerId = 5,
                            Title = "Refined Rubber Computer",
                            UpdatedAt = new DateTime(2022, 10, 29, 20, 4, 53, 562, DateTimeKind.Local).AddTicks(2275)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 1, 17, 10, 17, 10, 150, DateTimeKind.Local).AddTicks(1482),
                            Description = "Itaque quis voluptat",
                            OwnerId = 4,
                            Title = "Rustic Wooden Hat",
                            UpdatedAt = new DateTime(2022, 7, 20, 4, 45, 37, 149, DateTimeKind.Local).AddTicks(5511)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 9, 16, 10, 35, 7, 610, DateTimeKind.Local).AddTicks(7550),
                            Description = "Aut voluptates ullam",
                            OwnerId = 3,
                            Title = "Handmade Plastic Tuna",
                            UpdatedAt = new DateTime(2022, 6, 14, 22, 45, 45, 778, DateTimeKind.Local).AddTicks(1721)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 3, 18, 1, 50, 7, 176, DateTimeKind.Local).AddTicks(2990),
                            Description = "Quas animi et veniam",
                            OwnerId = 2,
                            Title = "Unbranded Soft Mouse",
                            UpdatedAt = new DateTime(2022, 4, 5, 22, 42, 36, 121, DateTimeKind.Local).AddTicks(2967)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 12, 23, 17, 0, 21, 94, DateTimeKind.Local).AddTicks(9239),
                            Description = "Dolores ad ut nemo v",
                            OwnerId = 4,
                            Title = "Small Steel Sausages",
                            UpdatedAt = new DateTime(2022, 10, 30, 7, 23, 50, 67, DateTimeKind.Local).AddTicks(1806)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 10, 30, 7, 48, 35, 306, DateTimeKind.Local).AddTicks(6404),
                            Description = "Placeat non ut labor",
                            OwnerId = 4,
                            Title = "Fantastic Rubber Cheese",
                            UpdatedAt = new DateTime(2022, 7, 24, 17, 3, 6, 466, DateTimeKind.Local).AddTicks(9937)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 8, 31, 13, 38, 51, 285, DateTimeKind.Local).AddTicks(3679),
                            Description = "Fuga repudiandae vol",
                            OwnerId = 4,
                            Title = "Practical Concrete Pizza",
                            UpdatedAt = new DateTime(2022, 11, 11, 3, 20, 4, 510, DateTimeKind.Local).AddTicks(6366)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 6, 23, 14, 17, 747, DateTimeKind.Local).AddTicks(8667),
                            Description = "Necessitatibus maxim",
                            OwnerId = 3,
                            Title = "Licensed Wooden Chair",
                            UpdatedAt = new DateTime(2022, 10, 25, 17, 47, 9, 562, DateTimeKind.Local).AddTicks(8907)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 10, 31, 14, 34, 13, 212, DateTimeKind.Local).AddTicks(5643),
                            Description = "Aspernatur voluptate",
                            OwnerId = 3,
                            Title = "Small Cotton Cheese",
                            UpdatedAt = new DateTime(2023, 1, 8, 6, 48, 39, 680, DateTimeKind.Local).AddTicks(8890)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 4, 11, 57, 20, 947, DateTimeKind.Local).AddTicks(3151),
                            Description = "Dolorem animi enim d",
                            OwnerId = 3,
                            Title = "Rustic Steel Keyboard",
                            UpdatedAt = new DateTime(2022, 12, 18, 3, 53, 0, 782, DateTimeKind.Local).AddTicks(5589)
                        });
                });

            modelBuilder.Entity("Colab.Models.ProjectUser", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("Colab.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Brooklyn.Conroy4@hotmail.com",
                            Name = "Reece Kassulke",
                            Password = "uGkfqKWKgz",
                            RoleId = 0
                        },
                        new
                        {
                            Id = 2,
                            Email = "Kaleigh.Cremin@yahoo.com",
                            Name = "Daisy Marks",
                            Password = "fBt1Cxi93C",
                            RoleId = 0
                        },
                        new
                        {
                            Id = 3,
                            Email = "Ava_Simonis@yahoo.com",
                            Name = "Deborah DuBuque",
                            Password = "CGA9XGzebW",
                            RoleId = 0
                        },
                        new
                        {
                            Id = 4,
                            Email = "Newton69@hotmail.com",
                            Name = "Norbert Hegmann",
                            Password = "Gei9bYve_w",
                            RoleId = 0
                        },
                        new
                        {
                            Id = 5,
                            Email = "Ian_Berge@hotmail.com",
                            Name = "Isaias Beahan",
                            Password = "9OXcQxRem7",
                            RoleId = 0
                        });
                });

            modelBuilder.Entity("Colab.Models.Assignment", b =>
                {
                    b.HasOne("Colab.Models.Project", "Project")
                        .WithMany("Assignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Colab.Models.Project", b =>
                {
                    b.HasOne("Colab.Models.User", "owner")
                        .WithMany("Projects")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");
                });

            modelBuilder.Entity("Colab.Models.ProjectUser", b =>
                {
                    b.HasOne("Colab.Models.Project", "Project")
                        .WithMany("Participators")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Colab.Models.User", "User")
                        .WithMany("Participations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Colab.Models.Project", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Participators");
                });

            modelBuilder.Entity("Colab.Models.User", b =>
                {
                    b.Navigation("Participations");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}