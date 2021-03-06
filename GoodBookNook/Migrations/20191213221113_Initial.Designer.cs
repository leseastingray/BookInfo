﻿// <auto-generated />
using System;
using GoodBookNook.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoodBookNook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191213221113_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoodBookNook.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<int?>("BookID");

                    b.Property<string>("Name");

                    b.HasKey("AuthorID");

                    b.HasIndex("BookID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("GoodBookNook.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("PubDate");

                    b.Property<string>("Title");

                    b.HasKey("BookID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("GoodBookNook.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText");

                    b.Property<int?>("UserNameUserID");

                    b.Property<int?>("UserReviewReviewID");

                    b.HasKey("CommentID");

                    b.HasIndex("UserNameUserID");

                    b.HasIndex("UserReviewReviewID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("GoodBookNook.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookID");

                    b.Property<string>("ReviewText");

                    b.Property<int?>("ReviewerUserID");

                    b.HasKey("ReviewID");

                    b.HasIndex("BookID");

                    b.HasIndex("ReviewerUserID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("GoodBookNook.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GoodBookNook.Models.Author", b =>
                {
                    b.HasOne("GoodBookNook.Models.Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookID");
                });

            modelBuilder.Entity("GoodBookNook.Models.Comment", b =>
                {
                    b.HasOne("GoodBookNook.Models.User", "UserName")
                        .WithMany("Comments")
                        .HasForeignKey("UserNameUserID");

                    b.HasOne("GoodBookNook.Models.Review", "UserReview")
                        .WithMany()
                        .HasForeignKey("UserReviewReviewID");
                });

            modelBuilder.Entity("GoodBookNook.Models.Review", b =>
                {
                    b.HasOne("GoodBookNook.Models.Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookID");

                    b.HasOne("GoodBookNook.Models.User", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerUserID");
                });
#pragma warning restore 612, 618
        }
    }
}
