using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Skill
    {
        [Column("SkillId")]
        public Guid Id { get; set; }

        [MaxLength(120)]
        public string? Title { get; set; }

        public int Perc { get; set; }
        public int Level { get; set; }

        [ForeignKey(nameof(SkillGroup))]
        public Guid SkillGroupId { get; set; }
        public SkillGroup? SkillGroup { get; set; }
    }
}
