using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Portfolio
    {
        [Column("PortfolioId")]
        public Guid Id { get; set; }

        [MaxLength(120)]
        public string? Name { get; set; }

        [MaxLength(250)]
        public string? PicUrl { get; set; }

        [MaxLength(250)]
        public string? UrlAddress { get; set; }
        public string? Desc { get; set; }

        [ForeignKey(nameof(PersonalInfo))]
        public Guid PersonalInfoId { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }
    }
}
