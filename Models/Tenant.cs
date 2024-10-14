using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RealStats.Models
{
    public class Tenant
    {
        public int Id { get; set; }

        [MaxLength(100), Required]
        public string Name { get; set; }

        public string Address { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Range(1, double.MaxValue), Required]
        public double Balance { get; set; }

        [Phone, Required]
        public string Phone { get; set; }
        public ICollection<LeaseAgreement> LeaseAgreement { get; set; } 
        public ICollection<Properity> Properity { get; set; }   
        public ICollection<ReportIssue> ReportIssue { get; set; }
    }
}
