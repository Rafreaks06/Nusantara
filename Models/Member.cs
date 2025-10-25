﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nusantara.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required, MaxLength(100)] public string Username { get; set; }
        [Required] public String PasswordHash { get; set; } = String.Empty;
        [Required, MaxLength(200)] public string FullName { get; set; } = String.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime JoinData { get; set; } = DateTime.UtcNow;
        public string MemberId { get; set; }
        public string IdCard { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneAlt { get; set; }
        public DateTime ModDate { get; set; }
        public string Status { get; set; }
        public string ReferenceId { get; set; }
        public string Level { get; set; }
        [Required, MaxLength(100)] public string quest1 { get; set; } = null;
        [Required, MaxLength(100)] public string quest2 { get; set; } = null;

        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
        public ICollection<Access> Accesses { get; set; } = new List<Access>();
        public ICollection<Saving> Savings { get; set; } = new List<Saving>();
        //public ICollection<Inhouse> OriginTransactions { get; set; } = new List<Inhouse>();
        //public ICollection<Inhouse> DestinationTransactions { get; set; } = new List<Inhouse>();
        //public ICollection<Excange> Excanges { get; set; }



    }
}
