using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SocialMedia
    {
        [Column("SocialMediaId")]
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        [MaxLength(250)]
        public string? Icon { get; set; }
        [MaxLength(250)]
        public string? UrlAddress { get; set; }

        [ForeignKey(nameof(PersonalInfo))]
        public Guid PersonalInfoId { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }

    }
}
