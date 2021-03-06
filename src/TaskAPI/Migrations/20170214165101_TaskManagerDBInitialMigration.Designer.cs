﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TaskAPI.Entities;

namespace TaskAPI.Migrations
{
    [DbContext(typeof(TaskManagementContext))]
    [Migration("20170214165101_TaskManagerDBInitialMigration")]
    partial class TaskManagerDBInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Entities.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BeginDateTime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("DeadlineDateTime")
                        .HasMaxLength(50);

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TaskId");

                    b.ToTable("Tasks");
                });
        }
    }
}
