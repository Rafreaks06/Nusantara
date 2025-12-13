using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Nusantara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nusantara.Data
{
    // Rafi
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members => Set<Member>();
        public DbSet<Access> Accesses => Set<Access>();
        public DbSet<Configuration> Configurations => Set<Configuration>();
        public DbSet<LoanMaster> LoanMaster => Set<LoanMaster>();
        public DbSet<Loan> Loans => Set<Loan>();
        public DbSet<Installment> Instalments => Set<Installment>();
        public DbSet<Saving> Savings => Set<Saving>();
        public DbSet<SavingMaster> SavingMasters => Set<SavingMaster>();
        //public DbSet<Inhouse> Inhouses => Set<Inhouse>();
        //public DbSet<Exchange> Exchanges => Set<Exchange>();

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=vb2_nusantara;Username=postgres;Password=miftahulrizky");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Member)
                .WithMany(m => m.Loans)
                .HasForeignKey(l => l.MemberId);

            modelBuilder.Entity<Installment>()
                .HasOne(i => i.Loan)
                .WithMany(l => l.Installments)
                .HasForeignKey(i => i.LoanId);

            modelBuilder.Entity<Access>()
                .HasOne(a => a.Member)
                .WithMany(m => m.Accesses)
                .HasForeignKey(a => a.MemberId);
            
            modelBuilder.Entity<Saving>()
                .HasOne(s => s.Member)
                .WithMany(m => m.Savings)
                .HasForeignKey(s => s.MemberId);

            /*modelBuilder.Entity<Inhouse>()
                .HasOne(x => x.Origin)
                .WithMany(m => m.OriginTransactions)
                .HasForeignKey(x => x.Origin);
            
            modelBuilder.Entity<Inhouse>()
                .HasOne(x => x.Destination)
                .WithMany(m => m.DestionationTransactions)
                .HasForeignKey(x => x.DestionationId);
            
            modelBuilder.Entity<Exchange>()
                .HasOne(x => x.Member)
                .WithMany(m => m.Exchanges)
                .HasForeignKey(x => x.MemberId);
            */
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var idrop = entity.FindProperty("id");
                if (idrop != null)
                {
                    idrop.SetValueGenerationStrategy(Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn);
                }
                                
            }
            modelBuilder.UseSerialColumns();
            base.OnModelCreating(modelBuilder);
        }
    }
}
