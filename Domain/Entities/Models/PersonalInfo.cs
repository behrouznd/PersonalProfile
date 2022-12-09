using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class PersonalInfo
    {
        [Column("PersonalInfoId")]
        public Guid Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string? Name { get; set; }

        [MaxLength(30)]
        [Required]
        public string? Family { get; set; }

        [MaxLength(40)]
        [Required]
        public string? Title { get; set; }

        [MaxLength(30)]
        public string? Nationality { get; set; }

        public DateTime Birthday { get; set; }

        public int MaritalStatus { get; set; }

        [MaxLength(30)]
        public string? Residence { get; set; }

        [MaxLength(20)]
        public string? Phone { get; set; }

        [MaxLength(20)]
        public string? Mobile { get; set; }

        [MaxLength(40)]
        public string? Email { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }

        public string? Introduction { get; set; }

        [MaxLength(200)]
        public string? PicProfile { get; set; }

        [ForeignKey(nameof(PersonalInfo))]
        public Guid LanguageId { get; set; }
        public Language? Language { get; set; }

        public ICollection<Experience>? Experiences { get; set; }
        public ICollection<Education>? Educations { get; set; }
        public ICollection<SkillGroup>? SkillGroups { get; set; }

        public ICollection<SocialMedia>? SocialMedias { get; set; }

        public ICollection<Portfolio>? Portfolios { get; set; }
        public ICollection<Certificate>? Certificates { get; set; }

    }
}
