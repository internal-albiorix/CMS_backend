﻿// <auto-generated />
using System;
using CandidateManagementSystem.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CandidateManagementSystem.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240527090924_AddCandidateHistory")]
    partial class AddCandidateHistory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.CandidateChartModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CandidateChart");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.CandidateHistoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InterviewRoundId")
                        .HasColumnType("int");

                    b.Property<string>("InterviewStartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InterviewerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("TimeLineDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("InterviewRoundId");

                    b.HasIndex("InterviewerId");

                    b.HasIndex("StatusId");

                    b.ToTable("CandidateHistory");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.CandidateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.CurrentOpeningModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Noofopening")
                        .HasColumnType("int");

                    b.Property<int>("TechnologyId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DesignationId");

                    b.HasIndex("TechnologyId");

                    b.ToTable("CurrentOpening");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.DesignationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DesignationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesignationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Designation");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.EmailTemplateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TemplateContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EmailTemplate");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.FeedBackModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CandidateFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("Codingstandard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Communication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InterviewRoundId")
                        .HasColumnType("int");

                    b.Property<string>("InterviewerFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Practicalcompletion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecommandedforPractical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Techanicalround")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TodayDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("InterviewRoundId");

                    b.ToTable("FeedBack");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.ForgotPasswordModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ForgotPassword");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.InquiriesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Inquiries");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.InterviewRoundModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InterviewRoundDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterviewRoundName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("InterviewRound");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.InterviewScheduleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InterviewRoundId")
                        .HasColumnType("int");

                    b.Property<int?>("InterviewerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("InterviewRoundId");

                    b.HasIndex("InterviewerId");

                    b.ToTable("InterviewSchedule");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.ReferEmployeeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CandidateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ReferEmployee");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.StatusModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("DisplayInAppointSchedule")
                        .HasColumnType("bit");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("StatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayInAppointSchedule = false,
                            IsActive = true,
                            StatusDescription = "New Candidate register",
                            StatusName = "New"
                        },
                        new
                        {
                            Id = 2,
                            DisplayInAppointSchedule = false,
                            IsActive = true,
                            StatusDescription = "Candidate in progress",
                            StatusName = "In Progress"
                        },
                        new
                        {
                            Id = 3,
                            DisplayInAppointSchedule = false,
                            IsActive = true,
                            StatusDescription = "Candidate is Selected",
                            StatusName = "Selected"
                        },
                        new
                        {
                            Id = 4,
                            DisplayInAppointSchedule = false,
                            IsActive = true,
                            StatusDescription = "Candidate Rejected",
                            StatusName = "Rejected"
                        },
                        new
                        {
                            Id = 5,
                            DisplayInAppointSchedule = false,
                            IsActive = true,
                            StatusDescription = "Candidate expectation not match",
                            StatusName = "Not Fit"
                        });
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.TechnologyAssociation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("FeedbackId")
                        .HasColumnType("int");

                    b.Property<int?>("InquiriesId")
                        .HasColumnType("int");

                    b.Property<int?>("ReferEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TechnologyId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("FeedbackId");

                    b.HasIndex("InquiriesId");

                    b.HasIndex("ReferEmployeeId");

                    b.HasIndex("TechnologyId");

                    b.HasIndex("UserId");

                    b.ToTable("TechnologyAssociation");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.TechnologyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TechnologyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechnologyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Technology");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.TimeFrameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TimeFrame");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Last 30 days",
                            value = 30
                        },
                        new
                        {
                            Id = 2,
                            Name = "Last 60 days",
                            value = 60
                        },
                        new
                        {
                            Id = 3,
                            Name = "Last 180 days",
                            value = 180
                        },
                        new
                        {
                            Id = 4,
                            Name = "Last 365 days",
                            value = 365
                        });
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DesignationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.CandidateHistoryModel", b =>
                {
                    b.HasOne("CandidateManagementSystem.Model.Model.CandidateModel", "CandidateModel")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandidateManagementSystem.Model.Model.InterviewRoundModel", "InterviewRoundModel")
                        .WithMany()
                        .HasForeignKey("InterviewRoundId");

                    b.HasOne("CandidateManagementSystem.Model.Model.UserModel", "InterviewerModel")
                        .WithMany()
                        .HasForeignKey("InterviewerId");

                    b.HasOne("CandidateManagementSystem.Model.Model.StatusModel", "StatusModel")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("CandidateModel");

                    b.Navigation("InterviewRoundModel");

                    b.Navigation("InterviewerModel");

                    b.Navigation("StatusModel");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.CandidateModel", b =>
                {
                    b.HasOne("CandidateManagementSystem.Model.Model.StatusModel", "StatusModel")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StatusModel");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.CurrentOpeningModel", b =>
                {
                    b.HasOne("CandidateManagementSystem.Model.Model.DesignationModel", "DesignationModel")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandidateManagementSystem.Model.Model.TechnologyModel", "TechnologyModel")
                        .WithMany()
                        .HasForeignKey("TechnologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DesignationModel");

                    b.Navigation("TechnologyModel");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.FeedBackModel", b =>
                {
                    b.HasOne("CandidateManagementSystem.Model.Model.CandidateModel", "CandidateModel")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandidateManagementSystem.Model.Model.InterviewRoundModel", "InterviewRoundModel")
                        .WithMany()
                        .HasForeignKey("InterviewRoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CandidateModel");

                    b.Navigation("InterviewRoundModel");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.InterviewScheduleModel", b =>
                {
                    b.HasOne("CandidateManagementSystem.Model.Model.CandidateModel", "CandidateModel")
                        .WithMany()
                        .HasForeignKey("CandidateId");

                    b.HasOne("CandidateManagementSystem.Model.Model.InterviewRoundModel", "InterviewRoundModel")
                        .WithMany()
                        .HasForeignKey("InterviewRoundId");

                    b.HasOne("CandidateManagementSystem.Model.Model.UserModel", "InterviewerModel")
                        .WithMany()
                        .HasForeignKey("InterviewerId");

                    b.Navigation("CandidateModel");

                    b.Navigation("InterviewRoundModel");

                    b.Navigation("InterviewerModel");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.TechnologyAssociation", b =>
                {
                    b.HasOne("CandidateManagementSystem.Model.Model.CandidateModel", "Candidate")
                        .WithMany("CandidateTechnologies")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CandidateManagementSystem.Model.Model.FeedBackModel", "Feedback")
                        .WithMany("FeedbackTechnologies")
                        .HasForeignKey("FeedbackId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CandidateManagementSystem.Model.Model.InquiriesModel", "Inquiries")
                        .WithMany("InquiriesTechnologies")
                        .HasForeignKey("InquiriesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CandidateManagementSystem.Model.Model.ReferEmployeeModel", "ReferEmployee")
                        .WithMany("ReferEmployeeTechnologies")
                        .HasForeignKey("ReferEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CandidateManagementSystem.Model.Model.TechnologyModel", "Technology")
                        .WithMany()
                        .HasForeignKey("TechnologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandidateManagementSystem.Model.Model.UserModel", "User")
                        .WithMany("UserTechnologies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Candidate");

                    b.Navigation("Feedback");

                    b.Navigation("Inquiries");

                    b.Navigation("ReferEmployee");

                    b.Navigation("Technology");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.UserModel", b =>
                {
                    b.HasOne("CandidateManagementSystem.Model.Model.DesignationModel", "DesignationModel")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DesignationModel");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.CandidateModel", b =>
                {
                    b.Navigation("CandidateTechnologies");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.FeedBackModel", b =>
                {
                    b.Navigation("FeedbackTechnologies");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.InquiriesModel", b =>
                {
                    b.Navigation("InquiriesTechnologies");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.ReferEmployeeModel", b =>
                {
                    b.Navigation("ReferEmployeeTechnologies");
                });

            modelBuilder.Entity("CandidateManagementSystem.Model.Model.UserModel", b =>
                {
                    b.Navigation("UserTechnologies");
                });
#pragma warning restore 612, 618
        }
    }
}
