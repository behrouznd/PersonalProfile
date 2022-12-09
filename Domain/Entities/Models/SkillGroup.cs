using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class SkillGroup
    {
        [Column("SkillGroupId")]
        public Guid Id { get; set; }
        [MaxLength(60)]
        public string? Title { get; set; }

        [ForeignKey(nameof(PersonalInfo))]
        public Guid PersonalInfoId { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }

        public ICollection<Skill>? Skills { get; set; }
    }
}
