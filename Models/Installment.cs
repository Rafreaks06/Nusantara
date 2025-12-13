using System;
using System.ComponentModel.DataAnnotations;

namespace Nusantara.Models
{
    public class Installment
    {
        public int Id { get; set; }

        [Required]
        public int LoanId { get; set; }

        // Navigation property
        public Loan? Loan { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        public string? ProofPath { get; set; }
    }
}
