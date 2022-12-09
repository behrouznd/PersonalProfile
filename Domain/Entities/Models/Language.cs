using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Language
    {
        [Column("LanguageId")]
        public Guid Id { get; set; }
   
        [MaxLength(40)]
        public string? Name { get; set; }

        [MaxLength(3)]
        public string? Abbreviation { get; set; }

        [MaxLength(120)]
        public string? PathFlag { get; set; }

        public PersonalInfo? PersonalInfo { get; set; }
    }
}
