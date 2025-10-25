using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nusantara.Data;
using Nusantara.Models;

namespace Nusantara.Services
{
    internal class AuthService
    {
        private readonly AppDbContext _db;
        public AuthService(AppDbContext db) => _db = db;

        public async Task<Member> LoginAsync(string username, string password)
        {
            var user = await _db.Members.FirstOrDefaultAsync(x => x.Username == username && x.IsActive);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return user;
            return null;
        }

        public async Task RegisterAsync(string username, string password, string fullname)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            var m = new Member
            {
                Username = username,
                PasswordHash = hash,
                FullName = fullname,
            };
            _db.Members.Add(m);
            await _db.SaveChangesAsync();
        }

        public async Task RegisterAsync(string address, string cardId, string email, string fullname,
            string password, string phone, string phonealt, string referenceid, string username,
            string quest1, string quest2)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            var memberId = RandomNumberGenerator.GetString("1234567890", 6);
            var m = new Member
            {
                Username = username,
                PasswordHash = hash,
                FullName = fullname,
                Email = email,
                Address = address,
                Phone = phone,
                PhoneAlt = phonealt,
                IdCard = cardId,
                ReferenceId = referenceid,
                Level = "public",
                IsActive = true,
                Status = "public",
                quest1 = quest1,
                quest2 = quest2,
                MemberId = memberId
            };

            _db.Members.Add(m);
            await _db.SaveChangesAsync();
        }

        public async Task<string> ResetPasswordAsync(string username, string quest1, string quest2)
        {
            var user = await _db.Members.FirstOrDefaultAsync(x => x.Username == username && x.IsActive && x.quest1 == quest1.Trim() && x.quest2 == quest2.Trim());
            if (user != null)
            {
                string password = RandomNumberGenerator.GetHexString(6, false);
                var hash = BCrypt.Net.BCrypt.HashPassword(password);
                user.PasswordHash = hash;
                _db.Members.Update(user);
                await _db.SaveChangesAsync();
                return password;
            }
            return "";
        }
    }
}

