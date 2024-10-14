using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealStats.Models
{
    public class ProperityStatus
    {
        [Key,ForeignKey("Properity")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Properity Properity { get; set; }
    }
}
