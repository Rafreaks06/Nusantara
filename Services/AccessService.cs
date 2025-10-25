using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nusantara.Data;
using Nusantara.Models;

namespace Nusantara.Services
{
    public class AccessService
    {
        private readonly AppDbContext _db;
        public AccessService(AppDbContext db) => _db = db;
        
        public async Task<Access?> GetAccess(int memberId)
        {
            var access = await _db.Accesses.FirstOrDefaultAsync(
                 x => x.MemberId == memberId);
                return access;

        }
        public object setGridView()
        {
            var grid = _db.Accesses.OrderBy(x => x.MemberId)
                .Select(x => new
                {
                    x.Id,
                    DisplayMember = x.Member.MemberId + "-" + x.Member.FullName,
                    x.AccessList,
                    x.updateOn
                }).ToList();
            return grid;
        }
        public Access? findByMemberId(int id)
        { 
            return _db.Accesses.FirstOrDefault(x => x.MemberId == id);
        }
        public async Task update(Access access, string accessList)
        {
            access.AccessList = accessList;
            access.updateOn = DateTime.Now;
            _db.Accesses.Update(access);
            await _db.SaveChangesAsync();
        }
        public async Task newOne(Access? access, Member member, String accessList)
        { 
            var a = new Access
            {
                MemberId = member.Id,
                AccessList = accessList,
                updateOn = DateTime.Now
            };
            _db.Add(a);
            await _db.SaveChangesAsync();
        }
    }
}
