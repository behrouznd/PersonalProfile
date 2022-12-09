using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Certificate
    {
        [Column("CertificateId")]
        public Guid Id { get; set; }
        [MaxLength(120)]
        public string? Title { get; set; }
        [MaxLength(120)]
        public string? Issuer { get; set; }
        public DateTime DateIssued { get; set; }

        [ForeignKey(nameof(PersonalInfo))]
        public Guid PersonalInfoId { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }
    }
}
