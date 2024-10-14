using System.ComponentModel.DataAnnotations;

namespace RealStats.Models
{
    public class Manager
    {
        public int Id { get; set; }

        [MaxLength(100), Required]
        public string Name { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; } 

        [Phone, Required]
        public string Phone { get; set; }
        public ICollection<Properity> Properities { get; set; }
        public ICollection<LeaseAgreement> LeaseAgreements { get; set; }    
    }
}
