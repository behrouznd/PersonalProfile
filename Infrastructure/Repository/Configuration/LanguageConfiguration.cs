using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(new Language { Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "Deutsch", Abbreviation = "De", PathFlag = "" },
                new Language { Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), 
                    Name = "English", Abbreviation = "En", PathFlag = "" });
        }
    }
}
