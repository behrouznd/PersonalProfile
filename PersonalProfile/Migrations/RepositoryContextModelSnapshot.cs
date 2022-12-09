﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace PersonalProfile.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Certificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CertificateId");

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("datetime2");

                    b.Property<string>("Issuer")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<Guid>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("Entities.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ContactId");

                    b.Property<string>("Email")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Message")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entities.Models.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EducationId");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("DegreeLevel")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Major")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("University")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Entities.Models.Experience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ExperienceId");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCurrently")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<Guid>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Entities.Models.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("LanguageId");

                    b.Property<string>("Abbreviation")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PathFlag")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Abbreviation = "De",
                            Name = "Deutsch",
                            PathFlag = ""
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Abbreviation = "En",
                            Name = "English",
                            PathFlag = ""
                        });
                });

            modelBuilder.Entity("Entities.Models.PersonalInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PersonalInfoId");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("Mobile")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PicProfile")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Residence")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId")
                        .IsUnique();

                    b.ToTable("PersonalInfos");
                });

            modelBuilder.Entity("Entities.Models.Portfolio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PortfolioId");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<Guid>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PicUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UrlAddress")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("Entities.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SkillId");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Perc")
                        .HasColumnType("int");

                    b.Property<Guid>("SkillGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.HasIndex("SkillGroupId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Entities.Models.SkillGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SkillGroupId");

                    b.Property<Guid>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("SkillGroups");
                });

            modelBuilder.Entity("Entities.Models.SocialMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SocialMediaId");

                    b.Property<string>("Icon")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("PersonalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UrlAddress")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("Entities.Models.Certificate", b =>
                {
                    b.HasOne("Entities.Models.PersonalInfo", "PersonalInfo")
                        .WithMany("Certificates")
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("Entities.Models.Education", b =>
                {
                    b.HasOne("Entities.Models.PersonalInfo", "PersonalInfo")
                        .WithMany("Educations")
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("Entities.Models.Experience", b =>
                {
                    b.HasOne("Entities.Models.PersonalInfo", "PersonalInfo")
                        .WithMany("Experiences")
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("Entities.Models.PersonalInfo", b =>
                {
                    b.HasOne("Entities.Models.Language", "Language")
                        .WithOne("PersonalInfo")
                        .HasForeignKey("Entities.Models.PersonalInfo", "LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Entities.Models.Portfolio", b =>
                {
                    b.HasOne("Entities.Models.PersonalInfo", "PersonalInfo")
                        .WithMany("Portfolios")
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("Entities.Models.Skill", b =>
                {
                    b.HasOne("Entities.Models.SkillGroup", "SkillGroup")
                        .WithMany("Skills")
                        .HasForeignKey("SkillGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SkillGroup");
                });

            modelBuilder.Entity("Entities.Models.SkillGroup", b =>
                {
                    b.HasOne("Entities.Models.PersonalInfo", "PersonalInfo")
                        .WithMany("SkillGroups")
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("Entities.Models.SocialMedia", b =>
                {
                    b.HasOne("Entities.Models.PersonalInfo", "PersonalInfo")
                        .WithMany("SocialMedias")
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("Entities.Models.Language", b =>
                {
                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("Entities.Models.PersonalInfo", b =>
                {
                    b.Navigation("Certificates");

                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Portfolios");

                    b.Navigation("SkillGroups");

                    b.Navigation("SocialMedias");
                });

            modelBuilder.Entity("Entities.Models.SkillGroup", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
