﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentTopicWeb.Data;

namespace StudentTopicWeb.Migrations
{
    [DbContext(typeof(StudentTopicWebContext))]
    [Migration("20201222051714_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("StudentTopicWeb.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TopicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("TopicId");

                    b.ToTable("Topic");
                });
#pragma warning restore 612, 618
        }
    }
}