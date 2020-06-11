using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MerchantQRPortalCore.Models
{
    public partial class MerchantQRContext : DbContext
    {
        public MerchantQRContext(DbContextOptions<MerchantQRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QrCodes> QrCodes { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<UserActions> UserActions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QrCodes>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("qrCodes");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("transactions");

                entity.HasIndex(e => e.MerchantQrcodeRecordId);

                entity.HasIndex(e => e.QrcodeRecordId);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MerchantQrcodeRecordId).HasColumnName("MerchantQRCodeRecordID");

                entity.Property(e => e.QrcodeRecordId).HasColumnName("QRCodeRecordID");

                entity.HasOne(d => d.MerchantQrcodeRecord)
                    .WithMany(p => p.TransactionsMerchantQrcodeRecord)
                    .HasForeignKey(d => d.MerchantQrcodeRecordId);

                entity.HasOne(d => d.QrcodeRecord)
                    .WithMany(p => p.TransactionsQrcodeRecord)
                    .HasForeignKey(d => d.QrcodeRecordId);
            });

            modelBuilder.Entity<UserActions>(entity =>
            {
                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.DateConducted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rolename).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
