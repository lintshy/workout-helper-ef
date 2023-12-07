﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using workout_helper_2.Data;

#nullable disable

namespace workout_helper_2.Migrations
{
    [DbContext(typeof(WorkoutHelperContext))]
    [Migration("20231207085512_AddEmailToUser")]
    partial class AddEmailToUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("workout_helper_2.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("workout_helper_2.Models.UserWorkOutSchedule", b =>
                {
                    b.Property<int>("UserWorkOrderScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserWorkOrderScheduleId"), 1L, 1);

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.Property<int>("dayOftheWeek")
                        .HasColumnType("int");

                    b.Property<int>("numberOfReps")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("UserWorkOrderScheduleId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("UserWorkOutSchedules");
                });

            modelBuilder.Entity("workout_helper_2.Models.Workout", b =>
                {
                    b.Property<int>("WorkOutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkOutId"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkOutId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("workout_helper_2.Models.UserWorkOutSchedule", b =>
                {
                    b.HasOne("workout_helper_2.Models.Workout", null)
                        .WithMany("UserWorkOutSchedules")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("workout_helper_2.Models.Workout", b =>
                {
                    b.Navigation("UserWorkOutSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}