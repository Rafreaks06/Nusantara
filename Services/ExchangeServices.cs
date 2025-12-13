using Nusantara.Data;
using Nusantara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nusantara.Services
{
    public class ExchangeServices
    {
        private readonly AppDbContext _db;
        public ExchangeServices(AppDbContext db) => _db = db;
        public async void save(Exchange exchange)
        {
            _db.Exchanges.Add(exchange);
            await _db.SaveChangesAsync();
        }
    }
   
}
