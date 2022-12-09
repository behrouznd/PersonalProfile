using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Language>?   Languages { get; set; }
        public DbSet<PersonalInfo>?  PersonalInfos { get; set; }
        public DbSet<Certificate>?   Certificates { get; set; }
        public DbSet<Contact>?   Contacts { get; set; }
        public DbSet<Education>?   Educations { get; set; }
        public DbSet<Experience>?   Experiences { get; set; }
        public DbSet<Portfolio>?   Portfolios { get; set; }
        public DbSet<Skill>? Skills { get; set; }
        public DbSet<SkillGroup>? SkillGroups { get; set; }
        public DbSet<SocialMedia>? SocialMedias { get; set; }
    }
}
