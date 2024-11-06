﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using husshussAPIBack.Data;

#nullable disable

namespace husshussAPIBack.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("husshussAPIBack.Models.Application", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ApplicationID"));

                    b.Property<int>("ApplicantID")
                        .HasColumnType("int");

                    b.Property<string>("Proposal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RelatedID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ApplicationID");

                    b.HasIndex("ApplicantID");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Campaign", b =>
                {
                    b.Property<int>("CampaignID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CampaignID"));

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SponsorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CampaignID");

                    b.HasIndex("SponsorID");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Influencer", b =>
                {
                    b.Property<int>("InfluencerID")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("EngagementRate")
                        .HasColumnType("float");

                    b.Property<int>("FollowerCount")
                        .HasColumnType("int");

                    b.Property<string>("SocialMediaHandles")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("InfluencerID");

                    b.ToTable("Influencers");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MessageID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsRead")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int>("SenderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("MessageID");

                    b.HasIndex("ReceiverID");

                    b.HasIndex("SenderID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Offer", b =>
                {
                    b.Property<int>("OfferID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OfferID"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("InfluencerID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("OfferID");

                    b.HasIndex("InfluencerID");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ReviewID"));

                    b.Property<int>("CampaignID")
                        .HasColumnType("int");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("RevieweeID")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerID")
                        .HasColumnType("int");

                    b.HasKey("ReviewID");

                    b.HasIndex("CampaignID");

                    b.HasIndex("RevieweeID");

                    b.HasIndex("ReviewerID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("husshussAPIBack.Models.SMMA", b =>
                {
                    b.Property<int>("SMMA_ID")
                        .HasColumnType("int");

                    b.Property<int>("ClientBase")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Expertise")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SMMA_ID");

                    b.ToTable("SMMAs");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Sponsor", b =>
                {
                    b.Property<int>("SponsorID")
                        .HasColumnType("int");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CompanyWebsite")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SponsorID");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("husshussAPIBack.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Application", b =>
                {
                    b.HasOne("husshussAPIBack.Models.User", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Campaign", b =>
                {
                    b.HasOne("husshussAPIBack.Models.Sponsor", "Sponsor")
                        .WithMany()
                        .HasForeignKey("SponsorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sponsor");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Influencer", b =>
                {
                    b.HasOne("husshussAPIBack.Models.User", "User")
                        .WithOne()
                        .HasForeignKey("husshussAPIBack.Models.Influencer", "InfluencerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Message", b =>
                {
                    b.HasOne("husshussAPIBack.Models.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("husshussAPIBack.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Offer", b =>
                {
                    b.HasOne("husshussAPIBack.Models.Influencer", "Influencer")
                        .WithMany()
                        .HasForeignKey("InfluencerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Influencer");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Review", b =>
                {
                    b.HasOne("husshussAPIBack.Models.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("husshussAPIBack.Models.User", "Reviewee")
                        .WithMany()
                        .HasForeignKey("RevieweeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("husshussAPIBack.Models.User", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("Reviewee");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("husshussAPIBack.Models.SMMA", b =>
                {
                    b.HasOne("husshussAPIBack.Models.User", "User")
                        .WithOne()
                        .HasForeignKey("husshussAPIBack.Models.SMMA", "SMMA_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("husshussAPIBack.Models.Sponsor", b =>
                {
                    b.HasOne("husshussAPIBack.Models.User", "User")
                        .WithOne()
                        .HasForeignKey("husshussAPIBack.Models.Sponsor", "SponsorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
