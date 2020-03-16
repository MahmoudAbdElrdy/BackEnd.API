﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BackEnd.DAL.Models
{
    public partial class LoGooContext : DbContext
    {
        public LoGooContext()
        {
        }

        public LoGooContext(DbContextOptions<LoGooContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<AdvertisementOpen> AdvertisementOpen { get; set; }
        public virtual DbSet<AdvertisementUpdate> AdvertisementUpdate { get; set; }
        public virtual DbSet<AdvertisementView> AdvertisementView { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerLogin> CustomerLogin { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<MarketFollow> MarketFollow { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=LoGoo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.ToTable("advertisement");

                entity.Property(e => e.AdsId)
                    .HasColumnName("ads_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdsImage).HasColumnName("ads_image");

                entity.Property(e => e.AdsText).HasColumnName("ads_text");

                entity.Property(e => e.AdsType).HasColumnName("ads_type");

                entity.Property(e => e.AdsVideo).HasColumnName("ads_video");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.Cityid).HasColumnName("cityid");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Marketid).HasColumnName("marketid");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.WaitingUpdate).HasColumnName("waiting_update");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.Cityid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_city");
            });

            modelBuilder.Entity<AdvertisementOpen>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.ToTable("advertisement_open");

                entity.Property(e => e.AdsId)
                    .HasColumnName("ads_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Customerid).HasColumnName("customerid");
            });

            modelBuilder.Entity<AdvertisementUpdate>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.ToTable("advertisement_update");

                entity.Property(e => e.AdsId)
                    .HasColumnName("ads_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdsImage).HasColumnName("ads_image");

                entity.Property(e => e.AdsText).HasColumnName("ads_text");

                entity.Property(e => e.AdsType).HasColumnName("ads_type");

                entity.Property(e => e.AdsVideo).HasColumnName("ads_video");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.Cityid).HasColumnName("cityid");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AdvertisementUpdate)
                    .HasForeignKey(d => d.Cityid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_update_city");
            });

            modelBuilder.Entity<AdvertisementView>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.ToTable("advertisement_View");

                entity.Property(e => e.AdsId)
                    .HasColumnName("ads_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AdvertisementView)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_View_customer");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Countryid).HasColumnName("countryid");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.Countryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_city_country");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryName).HasColumnName("country_name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cityid).HasColumnName("cityid");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Plateform).HasColumnName("plateform");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.Cityid)
                    .HasConstraintName("FK_customer_city");
            });

            modelBuilder.Entity<CustomerLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("customer_login");

                entity.Property(e => e.LoginId)
                    .HasColumnName("login_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.LoginDate)
                    .HasColumnName("login_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerLogin)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_login_customer");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.ToTable("market");

                entity.Property(e => e.MarketId)
                    .HasColumnName("market_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cityid).HasColumnName("cityid");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarketAddress).HasColumnName("market_address");

                entity.Property(e => e.MarketEmail)
                    .HasColumnName("market_email")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketInfo).HasColumnName("market_info");

                entity.Property(e => e.MarketLatlng).HasColumnName("market_latlng");

                entity.Property(e => e.MarketLogo).HasColumnName("market_logo");

                entity.Property(e => e.MarketName)
                    .HasColumnName("market_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPassword)
                    .HasColumnName("market_password")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPhone)
                    .IsRequired()
                    .HasColumnName("market_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Plateform).HasColumnName("plateform");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.Cityid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_market_city");
            });

            modelBuilder.Entity<MarketFollow>(entity =>
            {
                entity.HasKey(e => e.MarketCustomerId);

                entity.ToTable("market_follow");

                entity.Property(e => e.MarketCustomerId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Customerid).HasColumnName("customerid");

                entity.Property(e => e.Follow).HasColumnName("follow");

                entity.Property(e => e.Marketid).HasColumnName("marketid");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MarketFollow)
                    .HasForeignKey(d => d.Customerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_market_follow_customer");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.MarketFollow)
                    .HasForeignKey(d => d.Marketid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_market_follow_market");
            });
        }
    }
}
