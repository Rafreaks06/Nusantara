using Microsoft.EntityFrameworkCore;
using Nusantara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nusantara.Data
{
    internal class AppDbContext
    {
        public DbSet<Member> Members => Set<Member>();
        public DbSet<Access> Accesses => Set<Access>();
        public DbSet<Configuration> Configurations => DbSet<Configuration>();
        public DbSet<LoanMaster> LoanMaster => Set<LoanMaster>();
        public DbSet<Loan> Loans => Set<LoanMaster>();
        public DbSet<Installment> Instalments => Set<Insallment>();
        public DbSet<Saving> Savings => Set<Saving>();
        public DbSet<Inhouse> Inhouses => Set<Inhouse>();
        public DbSet<Exchange> Exchanges => Set<Exchange>();

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseNPGSQL(config.GetconnectionString("Default"));

        }
        protected override void OnmodelCreating(ModelBuilder modlBuilder)
        {
            ModelBuilder.Entity<Loan>()
                .Hashone(l => l.Member)
                .WithMany(m => m.Loans)
                .HasForeignKey(l => l.MemberId);
            ModelBuilder.Entity<Installment>()
                .Hashone(i => i.Loan)
                .WithMany(l => l.Installment)
                .HasForeignKey(i => i.LoanId);
            ModelBuilder.Entity<Access>()
                .Hashone(a => a.Member)
                .WithMany(m => m.Access)
                .HasForeignKey(a => a.MemberId);
            ModelBuilder.Entity<Saving>()
                .Hashone(s => s.Member)
                .WithMany(m => m.Saving)
                .HasForeignKey(s => s.MemberId);
            ModelBuilder.Entity<Inhouse>()
                .Hashone(x => x.Origin)
                .WithMany(m => m.OriginTransactions)
                .HasForeignKey(x => x.Origin);
            ModelBuilder.Entity<Exchange>()
                .Hashone(x => x.Member)
                .WithMany(m => m.Exchanges)
                .HasForeignKey(x => x.MemberId);

            foreach (var entity in ModelBuilder.Model.GetEntityTypes())
            {
                var idrop = entity.FindProperty("id")
                if (idrop != null)
                {
                    idrop.SetValueGenerationStrategy(
                        NpgsqlValueGenerationStrategy.SerialColum
                        );
                }
            }
        }
        Base.OnmodelCreating(ModelBuilder);
    }
}
