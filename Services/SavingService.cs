using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nusantara.Data;
using Nusantara.Models;

namespace Nusantara.Services
{
    public class SavingService
    {
        AppDbContext _db;

        public SavingService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Saving?> findById(int id) // search berdasarkan id
        {
            return await _db.Savings.FirstOrDefaultAsync(x => x.Id == id);
        }

        public List<Saving> findByName(String name) // search berdasarkan id
        {
            return _db.Savings.Where(x => x.Member.FullName == name).ToList<Saving>();
        }

        public async Task saveOrUpdate(Member member, string amount, string ktp,
            string kk, string slip, string dueDate, string interest,
             string interestFine, string savingId, string tenor, string adminFee)
        {
            int tenorLeft = int.Parse(tenor);
            decimal decAmount = decimal.Parse(amount);
            decimal decInterest = decimal.Parse(interest);
            decimal outstanding = (decAmount * (decInterest / 100) * tenorLeft) + decAmount;

            Saving l = new Saving
            {
                Amount = decAmount,
                CreatedOn = DateTime.UtcNow,
                DueDate = int.Parse(dueDate),
                Interest = decInterest,
                InterestFine = decimal.Parse(interestFine),
                KkPath = kk,
                KtpPath = ktp,
                SlipGajiPath = slip,
                SavingId = int.Parse(savingId),
                Tenor = tenorLeft,
                MemberId = member.Id,
                AdminFee = decimal.Parse(adminFee),
                TotalAmount = outstanding + decimal.Parse(adminFee)
            };
            // apa ini selanjutanya
        }

    }
}
