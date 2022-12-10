using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICertificateRepository> _certificateRepository;
        private readonly Lazy<IContactRepository> _contactRepository;
        private readonly Lazy<IEducationRepository> _educationRepository;
        private readonly Lazy<IExperienceRepository> _experienceRepository;
        private readonly Lazy<ILanguageRepository> _languageRepository;
        private readonly Lazy<IPersonalInfoRepository> _personalInfoRepository;
        private readonly Lazy<IPortfolioRepository> _portfolioRepository;
        private readonly Lazy<ISkillGroupRepository> _skillGroupRepository;
        private readonly Lazy<ISkillRepository> _skillRepository;
        private readonly Lazy<ISocialMediaRepository> _socialMediaRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _certificateRepository = new Lazy<ICertificateRepository>(() => new CertificateRepository(repositoryContext));
            _contactRepository = new Lazy<IContactRepository>(()=> new ContactRepository(repositoryContext));
            _educationRepository = new Lazy<IEducationRepository>(()=>new EducationRepository(repositoryContext));
            _experienceRepository = new Lazy<IExperienceRepository>(()=>new ExperienceRepository(repositoryContext));
            _languageRepository = new Lazy<ILanguageRepository>(()=>new LanguageRepository(repositoryContext));
            _personalInfoRepository = new Lazy<IPersonalInfoRepository>(()=> new PersonalInfoRepository(repositoryContext));
            _portfolioRepository = new Lazy<IPortfolioRepository>(()=> new PortfolioRepository(repositoryContext));
            _skillGroupRepository = new Lazy<ISkillGroupRepository>(()=> new SkillGroupRepository(repositoryContext));
            _skillRepository = new Lazy<ISkillRepository>(()=>new SkillRepository(repositoryContext));
            _socialMediaRepository = new Lazy<ISocialMediaRepository>(() => new SocialMediaRepository(repositoryContext));
        }

        public ICertificateRepository Certificate => _certificateRepository.Value;

        public IContactRepository Contact => _contactRepository.Value;

        public IEducationRepository Education => _educationRepository.Value;

        public IExperienceRepository Experience => _experienceRepository.Value;

        public ILanguageRepository Language => _languageRepository.Value;

        public IPersonalInfoRepository PersonalInfo => _personalInfoRepository.Value;

        public IPortfolioRepository Portfolio => _portfolioRepository.Value;

        public ISkillGroupRepository SkillGroup => _skillGroupRepository.Value;

        public ISkillRepository Skill => _skillRepository.Value;

        public ISocialMediaRepository SocialMedia => _socialMediaRepository.Value;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
