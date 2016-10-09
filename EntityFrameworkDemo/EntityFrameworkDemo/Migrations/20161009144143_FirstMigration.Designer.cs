using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EntityFrameworkDemo;

namespace EntityFrameworkDemo.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20161009144143_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("EntityFrameworkDemo.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DayOfBirth");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Picture");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("EntityFrameworkDemo.Person2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DayOfBirth");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Picture");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("EntityFrameworkDemo.Person3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DayOfBirth");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<byte[]>("Picture");

                    b.HasKey("Id");
                });
        }
    }
}
