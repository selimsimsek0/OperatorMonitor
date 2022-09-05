using Microsoft.EntityFrameworkCore;
using OperatorMonitor.Entity;

namespace OperatorMonitor.Data.Context
{
    public class OperatorDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseSqlServer(@"Server = .\SERVEREXPRESS; Database = OperatorDB; Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperationLog>(entity =>
            {
                entity.ToTable("tblOperationLog");

                entity.Property(p => p.LogID).HasColumnType("bigint").UseIdentityColumn().IsRequired();
                entity.Property(p => p.ComputerHash).HasColumnType("nvarchar(32)").IsRequired();
                entity.Property(p => p.IPAddress).HasColumnType("nvarchar(64)").IsRequired();
                entity.Property(p => p.UserID).HasColumnType("nvarchar(256)").IsRequired();
                entity.Property(p => p.Username).HasColumnType("nvarchar(64)").IsRequired();
                entity.Property(p => p.AccessLocation).HasColumnType("nvarchar(max)").IsRequired();
                entity.Property(p => p.AccessDirection).HasColumnType("int").IsRequired();
                entity.Property(p => p.VerifyStatusCode).HasColumnType("int").IsRequired();
                entity.Property(p => p.AdditionalInfo).HasColumnType("nvarchar(4000)").IsRequired();
                entity.Property(p => p.LogTime).HasColumnType("datetime").IsRequired();

                entity.HasKey(p => p.LogID);
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<OperationLog> OperationLogs { get; set; }
    }
}
