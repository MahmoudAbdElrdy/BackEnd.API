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
        public virtual DbSet<AdminUsers> AdminUsers { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<AdvertisementOpen> AdvertisementOpen { get; set; }
        public virtual DbSet<AdvertisementUpdate> AdvertisementUpdate { get; set; }
        public virtual DbSet<AdvertisementView> AdvertisementView { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<ContactUsMarket> ContactUsMarket { get; set; }
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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SQL5052.site4now.net;Database=DB_A56457_LookandGo;User Id=DB_A56457_LookandGo_admin;Password=Ta056178;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AboutUs>(entity =>
            {
                entity.Property(e => e.AboutUsId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Info).HasDefaultValueSql("('')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AdminUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.HasKey(e => e.AdsId)
                    .HasName("PK_advertisement");

                entity.Property(e => e.AdsId).ValueGeneratedNever();

                entity.Property(e => e.AdsImage).HasDefaultValueSql("('')");

                entity.Property(e => e.AdsText).HasDefaultValueSql("('')");

                entity.Property(e => e.AdsType).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdsVideo).HasDefaultValueSql("('')");

                entity.Property(e => e.Available).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Special).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WaitingUpdate).HasDefaultValueSql("((0))");

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

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_advertisement_Market");
            });

            modelBuilder.Entity<AdvertisementOpen>(entity =>
            {
                entity.HasKey(e => e.AdsOpenId)
                    .HasName("PK_advertisement_open");

                entity.Property(e => e.AdsOpenId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.HasOne(d => d.Ads)
                    .WithMany(p => p.AdvertisementOpen)
                    .HasForeignKey(d => d.AdsId)
                    .HasConstraintName("FK_advertisement_open_advertisement");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AdvertisementOpen)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_open_customer");
            });

            modelBuilder.Entity<AdvertisementUpdate>(entity =>
            {
                entity.HasKey(e => e.AdsUpdateId)
                    .HasName("PK_advertisement_update");

                entity.Property(e => e.AdsUpdateId).ValueGeneratedNever();

                entity.Property(e => e.AdsImage).HasDefaultValueSql("('')");

                entity.Property(e => e.AdsText).HasDefaultValueSql("('')");

                entity.Property(e => e.AdsType).HasDefaultValueSql("((0))");

                entity.Property(e => e.AdsVideo).HasDefaultValueSql("('')");

                entity.Property(e => e.Available).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Special).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Ads)
                    .WithMany(p => p.AdvertisementUpdate)
                    .HasForeignKey(d => d.AdsId)
                    .HasConstraintName("FK_advertisement_update_advertisement");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AdvertisementUpdate)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_update_city");
            });

            modelBuilder.Entity<AdvertisementView>(entity =>
            {
                entity.HasKey(e => e.AdsViewId)
                    .HasName("PK_advertisement_View");

                entity.Property(e => e.AdsViewId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.HasOne(d => d.Ads)
                    .WithMany(p => p.AdvertisementView)
                    .HasForeignKey(d => d.AdsId)
                    .HasConstraintName("FK_advertisement_View_advertisement");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AdvertisementView)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_advertisement_View_customer");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.Available).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryImage).HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_city_country");
            });

            modelBuilder.Entity<ContactUs>(entity =>
            {
                entity.Property(e => e.ContactUsId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Solved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ContactUs)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_contact_us_customer");
            });

            modelBuilder.Entity<ContactUsMarket>(entity =>
            {
                entity.HasKey(e => e.ContactUsId)
                    .HasName("PK_contact_us_market");

                entity.Property(e => e.ContactUsId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Solved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.ContactUsMarket)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_contact_us_market_market");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).ValueGeneratedNever();

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryName).HasDefaultValueSql("('')");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.Property(e => e.Token).HasDefaultValueSql("('')");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_customer_city");
            });

            modelBuilder.Entity<CustomerLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK_customer_login");

                entity.Property(e => e.LoginId).ValueGeneratedNever();

                entity.Property(e => e.LoginDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerLogin)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_login_customer");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.Property(e => e.MarketId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

                entity.Property(e => e.MarketAddress).HasDefaultValueSql("('')");

                entity.Property(e => e.MarketEmail)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarketInfo).HasDefaultValueSql("('')");

                entity.Property(e => e.MarketLatlng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarketLogo).HasDefaultValueSql("('')");

                entity.Property(e => e.MarketName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarketPassword)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarketPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Token).HasDefaultValueSql("('')");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_market_city");
            });

            modelBuilder.Entity<MarketFollow>(entity =>
            {
                entity.HasKey(e => e.MarketCustomerId)
                    .HasName("PK_market_follow");

                entity.Property(e => e.MarketCustomerId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");

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
                entity.Property(e => e.PrivacyId).ValueGeneratedNever();

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Content).HasDefaultValueSql("('')");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(hour,(3),getutcdate()))");
            });
        }
    }
}
