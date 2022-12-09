using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Education
    {
        [Column("EducationId")]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string? University { get; set; }

        [MaxLength(100)]
        public string? Major { get; set; }

        public int DegreeLevel { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        [MaxLength(60)]
        public string? Location { get; set; }

        [ForeignKey(nameof(PersonalInfo))]
        public Guid PersonalInfoId { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }
    }
}
