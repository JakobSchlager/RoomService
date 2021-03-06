// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoomDbLib;

namespace RoomDbLib.Migrations
{
    [DbContext(typeof(RoomDbContext))]
    partial class RoomDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("RoomDbLib.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("room");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Display: 3D, UHD"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Display: 3D"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Display: 3D, UHD"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Display: 3D, UHD"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Display: 4D"
                        });
                });

            modelBuilder.Entity("RoomDbLib.Entities.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("seat");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 9,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 11,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 12,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 13,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 14,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 15,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 16,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 17,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 18,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 19,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 20,
                            Description = "single Seat",
                            RoomId = 1
                        },
                        new
                        {
                            Id = 21,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 22,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 23,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 24,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 25,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 26,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 27,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 28,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 29,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 30,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 31,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 32,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 33,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 34,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 35,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 36,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 37,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 38,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 39,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 40,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 41,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 42,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 43,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 44,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 45,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 46,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 47,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 48,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 49,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 50,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 51,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 52,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 53,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 54,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 55,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 56,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 57,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 58,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 59,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 60,
                            Description = "single Seat",
                            RoomId = 2
                        },
                        new
                        {
                            Id = 61,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 62,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 63,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 64,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 65,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 66,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 67,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 68,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 69,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 70,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 71,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 72,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 73,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 74,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 75,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 76,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 77,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 78,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 79,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 80,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 81,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 82,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 83,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 84,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 85,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 86,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 87,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 88,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 89,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 90,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 91,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 92,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 93,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 94,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 95,
                            Description = "single Seat",
                            RoomId = 3
                        },
                        new
                        {
                            Id = 96,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 97,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 98,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 99,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 100,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 101,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 102,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 103,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 104,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 105,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 106,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 107,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 108,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 109,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 110,
                            Description = "single Seat",
                            RoomId = 4
                        },
                        new
                        {
                            Id = 111,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 112,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 113,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 114,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 115,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 116,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 117,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 118,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 119,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 120,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 121,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 122,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 123,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 124,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 125,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 126,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 127,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 128,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 129,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 130,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 131,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 132,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 133,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 134,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 135,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 136,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 137,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 138,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 139,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 140,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 141,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 142,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 143,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 144,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 145,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 146,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 147,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 148,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 149,
                            Description = "single Seat",
                            RoomId = 5
                        },
                        new
                        {
                            Id = 150,
                            Description = "single Seat",
                            RoomId = 5
                        });
                });

            modelBuilder.Entity("RoomDbLib.Entities.Seat", b =>
                {
                    b.HasOne("RoomDbLib.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
