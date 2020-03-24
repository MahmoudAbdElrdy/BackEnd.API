using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BackEnd.DAL.Models
{
    public partial class DB_A56457_LookandGoContext : DbContext
    {
        public DB_A56457_LookandGoContext()
        {
        }

        public DB_A56457_LookandGoContext(DbContextOptions<DB_A56457_LookandGoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<AdvertisementOpen> AdvertisementOpen { get; set; }
        public virtual DbSet<AdvertisementUpdate> AdvertisementUpdate { get; set; }
        public virtual DbSet<AdvertisementView> AdvertisementView { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerLogin> CustomerLogin { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<MarketFollow> MarketFollow { get; set; }
        public virtual DbSet<Privacy> Privacy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guIdance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SQL5052.site4now.net;Database=DB_A56457_LookandGo;User Id=DB_A56457_LookandGo_admin;Password=Ta056178;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AboutUs>(entity =>
            {
                entity.ToTable("AboutUs");

                entity.Property(e => e.AboutUsId)
                    .HasColumnName("AboutUsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Info).HasColumnName("Info");

                entity.Property(e => e.Phone)
                    .HasColumnName("Phone")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.ToTable("Advertisement");

                entity.Property(e => e.AdsId)
                    .HasColumnName("AdsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdsImage).HasColumnName("AdsImage");

                entity.Property(e => e.AdsText).HasColumnName("AdsText");

                entity.Property(e => e.AdsType).HasColumnName("AdsType");

                entity.Property(e => e.AdsVideo).HasColumnName("AdsVideo");

                entity.Property(e => e.Available).HasColumnName("Available");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryId");

                entity.Property(e => e.CityId).HasColumnName("CityId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarketId).HasColumnName("MarketId");

                entity.Property(e => e.StartDate)
                    .HasColumnName("StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WaitingUpdate).HasColumnName("WaitingUpdate");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_category");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_city");
            });

            modelBuilder.Entity<AdvertisementOpen>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.ToTable("AdvertisementOpen");

                entity.Property(e => e.AdsId)
                    .HasColumnName("AdsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerId");
            });

            modelBuilder.Entity<AdvertisementUpdate>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.ToTable("AdvertisementUpdate");

                entity.Property(e => e.AdsId)
                    .HasColumnName("AdsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdsImage).HasColumnName("AdsImage");

                entity.Property(e => e.AdsText).HasColumnName("AdsText");

                entity.Property(e => e.AdsType).HasColumnName("AdsType");

                entity.Property(e => e.AdsVideo).HasColumnName("AdsVideo");

                entity.Property(e => e.Available).HasColumnName("Available");

                entity.Property(e => e.CityId).HasColumnName("CityId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDate)
                    .HasColumnName("StartDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AdvertisementUpdate)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_update_city");
            });

            modelBuilder.Entity<AdvertisementView>(entity =>
            {
                entity.HasKey(e => e.AdsId);

                entity.ToTable("AdvertisementView");

                entity.Property(e => e.AdsId)
                    .HasColumnName("AdsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AdvertisementView)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_View_customer");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Available).HasColumnName("Available");

                entity.Property(e => e.CategoryImage).HasColumnName("CategoryImage");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("CategoryName")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId)
                    .HasColumnName("CityId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .HasColumnName("CityName")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_city_country");
            });

            modelBuilder.Entity<ContactUs>(entity =>
            {
                entity.ToTable("ContactUs");

                entity.Property(e => e.ContactUsId)
                    .HasColumnName("ContactUsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerId");

                entity.Property(e => e.Email)
                    .HasColumnName("Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Plateform).HasColumnName("Plateform");

                entity.Property(e => e.Solved).HasColumnName("Solved");

                entity.Property(e => e.Title)
                    .HasColumnName("Title")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ContactUs)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_contact_us_customer");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryName).HasColumnName("CountryName");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("CityId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Plateform).HasColumnName("Plateform");

                entity.Property(e => e.Token).HasColumnName("Token");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_customer_city");
            });

            modelBuilder.Entity<CustomerLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("CustomerLogin");

                entity.Property(e => e.LoginId)
                    .HasColumnName("LoginId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerId");

                entity.Property(e => e.LoginDate)
                    .HasColumnName("LoginDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerLogin)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_login_customer");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.ToTable("Market");

                entity.Property(e => e.MarketId)
                    .HasColumnName("MarketId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Available).HasColumnName("Available");

                entity.Property(e => e.CityId).HasColumnName("CityId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarketAddress).HasColumnName("MarketAddress");

                entity.Property(e => e.MarketEmail)
                    .HasColumnName("MarketEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketInfo).HasColumnName("MarketInfo");

                entity.Property(e => e.MarketLatlng).HasColumnName("MarketLatlng");

                entity.Property(e => e.MarketLogo).HasColumnName("MarketLogo");

                entity.Property(e => e.MarketName)
                    .HasColumnName("MarketName")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPassword)
                    .HasColumnName("MarketPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPhone)
                    .IsRequired()
                    .HasColumnName("MarketPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.Plateform).HasColumnName("Plateform");

                entity.Property(e => e.Token).HasColumnName("Token");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_market_city");
            });

            modelBuilder.Entity<MarketFollow>(entity =>
            {
                entity.HasKey(e => e.MarketCustomerId);

                entity.ToTable("MarketFollow");

                entity.Property(e => e.MarketCustomerId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerId");

                entity.Property(e => e.Follow).HasColumnName("Follow");

                entity.Property(e => e.MarketId).HasColumnName("MarketId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MarketFollow)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_market_follow_customer");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.MarketFollow)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_market_follow_market");
            });

            modelBuilder.Entity<Privacy>(entity =>
            {
                entity.ToTable("Privacy");

                entity.Property(e => e.PrivacyId)
                    .HasColumnName("PrivacyId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content).HasColumnName("Content");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CreationDate")
                    .HasColumnType("datetime");
            });
        }
    }
}
