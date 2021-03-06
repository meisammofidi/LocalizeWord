﻿// <auto-generated />
using System;
using LocalizeWord.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalizeWord.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("LocalizeWord.API.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("ListKey");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Lists");
                });

            modelBuilder.Entity("LocalizeWord.API.Models.ListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("ItemKey");

                    b.Property<int>("ListId");

                    b.Property<int>("Oridinal");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.ToTable("ListItems");
                });

            modelBuilder.Entity("LocalizeWord.API.Models.ListItemCaption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption");

                    b.Property<string>("Language");

                    b.Property<int>("ListItemId");

                    b.HasKey("Id");

                    b.HasIndex("ListItemId");

                    b.ToTable("ListItemCaptions");
                });

            modelBuilder.Entity("LocalizeWord.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LocalizeWord.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("LocalizeWord.API.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Context");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LanguageId");

                    b.Property<int?>("LoanWordId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("LoanWordId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("LocalizeWord.API.Models.ListItem", b =>
                {
                    b.HasOne("LocalizeWord.API.Models.List", "List")
                        .WithMany("ListItems")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LocalizeWord.API.Models.ListItemCaption", b =>
                {
                    b.HasOne("LocalizeWord.API.Models.ListItem", "ListItem")
                        .WithMany("ListItemCaptions")
                        .HasForeignKey("ListItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LocalizeWord.API.Models.Word", b =>
                {
                    b.HasOne("LocalizeWord.API.Models.ListItem", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LocalizeWord.API.Models.ListItem", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LocalizeWord.API.Models.Word", "LoanWord")
                        .WithMany("NativeWords")
                        .HasForeignKey("LoanWordId");
                });
#pragma warning restore 612, 618
        }
    }
}
