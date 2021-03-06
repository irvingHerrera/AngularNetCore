﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Angular1.Models
{
    public partial class AngularCRUDTestContext : DbContext
    {
        public virtual DbSet<Employees> Employees { get; set; }

        public AngularCRUDTestContext(DbContextOptions<AngularCRUDTestContext> options) : base (options)
        {

        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=.;Database=AngularCRUDTest;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
