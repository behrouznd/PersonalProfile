using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Experience
    {
        [Column("ExperienceId")]
        public Guid Id { get; set; }

        [MaxLength(120)]
        public string? JobTitle { get; set; }

        [MaxLength(120)]
        public string? CompanyName { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool IsCurrently { get; set; }
        public string? DescExperience { get; set; }

        [ForeignKey(nameof(PersonalInfo))]
        public Guid PersonalInfoId { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }
    }
}
