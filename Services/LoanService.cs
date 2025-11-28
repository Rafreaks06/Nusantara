using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nusantara.Data;
using Nusantara.Models;

namespace Nusantara.Services
{
    public class LoanService
    {
        AppDbContext _db;
        public LoanService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Loan?> findById(int id)
        {
            return await _db.Loans.FirstOrDefaultAsync(x => x.id == id);
        }

        //public async Task<List<Installment>> LoadInstallmentGrid(int loanId)
        //{
        //    return await _db.Set<Installment>().Where(x => x.LoanId == loanId)
        //        .OrderBy(x => x.DueDate)
        //        .ToListAsync();
        //}

        public async Task<List<Loan>> LoadLoanGridByMemberIdAsync(int memberId)
        {
            return await _db.Loans
                .Where(x => x.MemberId == memberId)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();
        }

        public async Task saveOrUpdate(Member member, string amount, string Ktp, string KK, string gaji, string dueDate,
            string interest, string interestFine, string loanId, string tenor, string adminFee)
        {
            int tenorleft = int.Parse(tenor);
            decimal decamount = decimal.Parse(amount);
            decimal decinterest = decimal.Parse(interest);
            decimal decInterestFine = decimal.Parse(interestFine);
            decimal decAdminFee = decimal.Parse(adminFee);
            decimal outstanding = (decamount * (decinterest / 100) * tenorleft + decamount);

            Loan l = new Loan
            {
                Amount = decamount,
                CreatedOn = DateTime.UtcNow,
                DueDate = int.Parse(dueDate),
                Interest = decinterest,
                InterestFine = decInterestFine,
                KkpPath = KK,
                KtpPath = Ktp,
                Path = gaji,
                LoanId = int.Parse(loanId),
                Tenor = tenorleft,
                Tenorleft = tenorleft,
                AdminFee = decAdminFee,
                MemberId = member.Id,
                Outstanding = outstanding,
                TotalAmount = outstanding + decAdminFee,
                Status = "Pending"
            };
            _db.Loans.Add(l);
            await _db.SaveChangesAsync();
        }

        //public object LoadApproval()
        //{
        //    return _db.Loans.Where(x => x.ApprovedOn == null)
        //        .Include(x => x.Member)
        //        .OrderByDescending(x => x.CreatedOn)
        //        .Select(x => new
        //        {
        //            x.Id,
        //            MemberData = x.Member.MemberId + " - " + x.Member.FullName,
        //            JoinDate = x.Member.JoinDate.ToString("f"),
        //            x.LoanId,
        //            x.Amount,
        //            x.Outstanding,
        //            RequestDate = x.CreatedOn.ToString("f"),
        //            x.Tenor,
        //            x.Interest,
        //            Kk = x.KkPath,
        //            Ktp = x.KtpPath,
        //            Slip = x.SlipGajiPath
        //        })
        //        .ToList();
        //}

        public async Task<List<Loan>> LoadsApproval()
        {
            return await _db.Loans
                .Where(x => x.ApprovedOn == null)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();
        }

        public async Task SetApproval(int id, bool isApprove)
        {
            var l = await _db.Loans.FirstOrDefaultAsync(x => x.id == id);
            if (l != null)
            {
                l.ApprovedOn = DateTime.UtcNow;
                l.IsApproved = isApprove;
                _db.Loans.Update(l);
                await _db.SaveChangesAsync();
            }
        }

        //public async Task saveOrUpdateInstallment(int loanId, string amount, string path)
        //{
        //    Installment i = new Installment
        //    {
        //        LoanId = loanId,
        //        Amount = decimal.Parse(amount),
        //        PatmentDate = DateTime.UtcNow,
        //        proofPath = path
        //    };
        //    _db.Set<Installment>().Add(i);
        //    await _db.SaveChangesAsync();
        //}

        public async Task recalculateLoan(int loanId, string amount, string path)
        {
            decimal payment = decimal.Parse(amount);
            int todaysDate = DateTime.UtcNow.Day;
            var l = await _db.Loans.FirstOrDefaultAsync(x => x.id == loanId);
            if (l != null)
            {
                if (todaysDate > l.DueDate)
                {
                    l.Fine = (l.Amount * l.InterestFine) + l.Fine;
                    l.TotalAmount += l.Fine;
                }
                l.Outstanding -= payment;
                l.TotalAmount -= payment;
                if (l.Outstanding <= 0 && l.TotalAmount > 0)
                {
                    l.Tenorleft = 1;
                }
                else if (l.Outstanding > 0)
                {
                    l.Tenorleft = l.Tenorleft - 1;
                }
                else
                {
                    l.Tenorleft = 0;
                }
                _db.Loans.Update(l);
                await _db.SaveChangesAsync();
            }
        }
    }
}
    