using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nusantara.Data;
using Nusantara.Models;

namespace Nusantara.Services
{
    public class ConfigurationService
    {
        private readonly AppDbContext _db;
        public ConfigurationService(AppDbContext db) => _db = db;

        public async Task<Configuration?> GetConfig()
        {
            var config = await _db.Configurations.FirstOrDefaultAsync(x => x.Id == 1);
            return config;
        }

        public async Task addOrUpdate(string terminologi1, string terminologi2, string terminologi3, decimal exchangeRate, decimal inhouseFee, decimal accrrossFee)
        {
            Boolean isNew = false;
            var config = await _db.Configurations.FirstOrDefaultAsync(x => x.Id == 1);

            if (config == null)
            {
                isNew = true;
                config = new Configuration();
            }

            config.terminologi1 = terminologi1;
            config.terminologi2 = terminologi2;
            config.terminologi3 = terminologi3;
            config.exchangeRate = exchangeRate;
            config.transferInhouseFee = inhouseFee;
            config.transferAcrossFee = accrrossFee;

            if (isNew)
            {
                _db.Configurations.Add(config);
            }
            else
            {
                _db.Configurations.Update(config);
            }

            await _db.SaveChangesAsync();
        }
    }
}
