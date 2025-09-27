using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nusantara.Models
{
    internal class SavingMaster
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal interest { get; set; }
        public decimal fine { get; set; }
        public decimal AdminFee { get; set; }
        public decimal MinAmount { get; set; } = 0;
        public decimal maxAmount { get; set; } = 0;
        public int Tenor { get; set; }
        public DateTime UpdateOn { get; set; }

    }   
    }
