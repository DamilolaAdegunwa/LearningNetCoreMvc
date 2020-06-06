﻿// <auto-generated />
using System;
using Learning.NetCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Learning.NetCore.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(kuchenDbContext))]
    [Migration("20190403081811_UpdateD")]
    partial class UpdateD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("ContactNumber");

                    b.Property<DateTime?>("CreateTime");

                    b.Property<int>("CreateUserId");

                    b.Property<int>("IsDeleted");

                    b.Property<string>("Manager");

                    b.Property<string>("Name");

                    b.Property<int>("ParentId");

                    b.Property<string>("Remarks");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Icon");

                    b.Property<string>("Name");

                    b.Property<int>("ParentId");

                    b.Property<string>("Remarks");

                    b.Property<int>("SerialNumber");

                    b.Property<int>("Type");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime?>("CreateTime");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("Name");

                    b.Property<string>("Remarks");

                    b.HasKey("Id");

                    b.HasIndex("CreateUserId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.RoleMenu", b =>
                {
                    b.Property<int>("MenuId");

                    b.Property<int>("RoleId");

                    b.Property<int>("Id");

                    b.Property<int?>("MenuId1");

                    b.HasKey("MenuId", "RoleId");

                    b.HasIndex("MenuId1");

                    b.ToTable("RoleMenus");
                });

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateTime");

                    b.Property<int>("CreateUserId");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("EMail");

                    b.Property<int>("IsDeleted");

                    b.Property<DateTime>("LastLoginTime");

                    b.Property<int>("LoginTimes");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Remarks");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<int>("Id");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.Role", b =>
                {
                    b.HasOne("Learning.NetCore.Domain.Entities.User", "CreateUser")
                        .WithMany()
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.RoleMenu", b =>
                {
                    b.HasOne("Learning.NetCore.Domain.Entities.Role", "Role")
                        .WithMany("Menus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Learning.NetCore.Domain.Entities.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId1");
                });

            modelBuilder.Entity("Learning.NetCore.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("Learning.NetCore.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Learning.NetCore.Domain.Entities.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}