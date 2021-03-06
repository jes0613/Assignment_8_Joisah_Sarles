// <auto-generated />
using Assignment_8_Joisah_Sarles.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment_8_Joisah_Sarles.Migrations
{
    [DbContext(typeof(FamazonDbContext))]
    partial class FamazonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Assignment_8_Joisah_Sarles.Models.Book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("authorFirst")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("authorLast")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("authorMiddle")
                        .HasColumnType("TEXT");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("classification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("isbn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("pages")
                        .HasColumnType("INTEGER");

                    b.Property<double>("price")
                        .HasColumnType("REAL");

                    b.Property<string>("publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("bookId");

                    b.ToTable("books");
                });
#pragma warning restore 612, 618
        }
    }
}
