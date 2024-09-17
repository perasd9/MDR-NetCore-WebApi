﻿// <auto-generated />
using System;
using BookWebApp.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookWebApp.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookWebApp.Core.Domain.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookType")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("NumberOfCopies")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.ToTable("Books", t =>
                        {
                            t.HasCheckConstraint("Book_TypeOfBook_Enum_Constraint", "BookType IN ('Drama','Romance','Comedy')");
                        });
                });

            modelBuilder.Entity("BookWebApp.Core.Domain.Confirmation", b =>
                {
                    b.Property<Guid>("ConfirmationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ConfirmationNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LibrarianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Processed")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ConfirmationId");

                    b.HasIndex("BookId");

                    b.HasIndex("LibrarianId");

                    b.HasIndex("UserId");

                    b.ToTable("Confirmations");
                });

            modelBuilder.Entity("BookWebApp.Core.Domain.Librarian", b =>
                {
                    b.Property<Guid>("LibrarianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibrarianId");

                    b.ToTable("Librarians");
                });

            modelBuilder.Entity("BookWebApp.Core.Domain.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookWebApp.Core.Domain.Confirmation", b =>
                {
                    b.HasOne("BookWebApp.Core.Domain.Book", "Book")
                        .WithMany("Confirmations")
                        .HasForeignKey("BookId");

                    b.HasOne("BookWebApp.Core.Domain.Librarian", "Librarian")
                        .WithMany("Confirmations")
                        .HasForeignKey("LibrarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWebApp.Core.Domain.User", "User")
                        .WithMany("Confirmations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Librarian");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookWebApp.Core.Domain.Book", b =>
                {
                    b.Navigation("Confirmations");
                });

            modelBuilder.Entity("BookWebApp.Core.Domain.Librarian", b =>
                {
                    b.Navigation("Confirmations");
                });

            modelBuilder.Entity("BookWebApp.Core.Domain.User", b =>
                {
                    b.Navigation("Confirmations");
                });
#pragma warning restore 612, 618
        }
    }
}
