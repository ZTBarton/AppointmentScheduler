﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.Models;

namespace Project2.Migrations
{
    [DbContext(typeof(ApptContext))]
    [Migration("20220324030416_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21");

            modelBuilder.Entity("Project2.Models.Appt", b =>
                {
                    b.Property<DateTime>("ApptDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("GroupPhone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApptDate");

                    b.ToTable("Appts");
                });
#pragma warning restore 612, 618
        }
    }
}