﻿// <auto-generated />
using System;
using Botler.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Botler.Database.Migrations
{
    [DbContext(typeof(SqliteContext))]
    partial class SqliteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Botler.Database.Dbos.MessageDbo", b =>
                {
                    b.Property<Guid>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DestinationChannelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationMessageId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DestinationPlatform")
                        .HasColumnType("int");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("bit");

                    b.Property<string>("MessageAdditionalDataJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginChannelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginMessageId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OriginPlatform")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimestampUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("InternalId");

                    b.HasIndex("DestinationMessageId", "DestinationPlatform");

                    b.HasIndex("OriginMessageId", "OriginPlatform");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
