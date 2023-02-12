﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookupApi.Models;

#nullable disable

namespace ParksLookupApi.Migrations
{
    [DbContext(typeof(ParksLookupApiContext))]
    partial class ParksLookupApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksLookupApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Activities")
                        .HasColumnType("longtext");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Activities = " Camping, Hiking, Snowshoeing, Fishing, WildLife Observation. Visitor Information Line: 970-586-1206",
                            Address = "1000 Highway 36, Estes Park, CO 80517",
                            Category = "National Park",
                            Name = "Rocky Mountain National Park"
                        },
                        new
                        {
                            ParkId = 2,
                            Activities = " Camping, Hiking, Cliff Dwelling Tours, Bird Watching, Geologic Views. Visitor information Line: 970-529-4465",
                            Address = " Mesa Verde, CO",
                            Category = "National Park",
                            Name = "Mesa Verde National Park"
                        },
                        new
                        {
                            ParkId = 3,
                            Activities = "Camping, Birding, Trails, Fishing, Boating, Biking. Park Office number: 720-520-1876",
                            Address = "13401 Picadilly Rd, Brighton, CO 80603",
                            Category = "State Park",
                            Name = "Barr Lake"
                        },
                        new
                        {
                            ParkId = 4,
                            Activities = " Camping, Birding, Trails, Fishing, Boating, Biking, Snowshoeing, Cross-Country Skiing, Kayaking. Park Offic number: 970-879-3922",
                            Address = " 61105 RCR 129, Clark, CO 80429",
                            Category = "State Park",
                            Name = "Steamboat Lake"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}