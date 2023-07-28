﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StackoverflowChatbot.Database;

#nullable disable

namespace StackoverflowChatbot.Migrations
{
    [DbContext(typeof(SqliteContext))]
    [Migration("20230728102812_UseGuidKeys")]
    partial class UseGuidKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("StackoverflowChatbot.Database.Dbos.MessageDbo", b =>
                {
                    b.Property<Guid>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DestinationChannelId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DestinationMessageId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DestinationPlatform")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MessageAdditionalDataJson")
                        .HasColumnType("TEXT");

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginAuthor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginChannelId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginMessageId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OriginPlatform")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimestampUtc")
                        .HasColumnType("TEXT");

                    b.HasKey("InternalId");

                    b.HasIndex("DestinationMessageId", "DestinationPlatform");

                    b.HasIndex("OriginMessageId", "OriginPlatform");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
