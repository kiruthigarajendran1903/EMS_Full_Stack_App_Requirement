﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhaseEnd1.Data;

#nullable disable

namespace PhaseEnd1.Migrations
{
    [DbContext(typeof(emsDbContext))]
    partial class emsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EMS_Full_App_Req.Models.DeptMaster", b =>
                {
                    b.Property<int>("DeptCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptCode"), 1L, 1);

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptCode");

                    b.ToTable("DeptMaster");
                });

            modelBuilder.Entity("EMS_Full_App_Req.Models.EmpProfile", b =>
                {
                    b.Property<int>("EmpCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpCode"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptCode")
                        .HasColumnType("int");

                    b.Property<int>("DeptMasterDeptCode")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpCode");

                    b.HasIndex("DeptMasterDeptCode");

                    b.ToTable("EmpProfile");
                });

            modelBuilder.Entity("EMS_Full_App_Req.Models.EmpProfile", b =>
                {
                    b.HasOne("EMS_Full_App_Req.Models.DeptMaster", "DeptMaster")
                        .WithMany("EmpProfiles")
                        .HasForeignKey("DeptMasterDeptCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeptMaster");
                });

            modelBuilder.Entity("EMS_Full_App_Req.Models.DeptMaster", b =>
                {
                    b.Navigation("EmpProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
