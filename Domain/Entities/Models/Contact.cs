using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Contact
    {
        [Column("ContactId")]
        public Guid Id { get; set; }

        [MaxLength(60)]
        public string? Name { get; set; }

        [MaxLength(120)]
        public string? Email { get; set; }

        [MaxLength(500)]
        public string? Message { get; set; }
    }
}
