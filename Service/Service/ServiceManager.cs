using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICertificateService> _certificateService;
        private readonly Lazy<IContactService> _contactService;
        private readonly Lazy<IEducationService> _educationService;
        private readonly Lazy<IExperienceService> _experienceService;
        private readonly Lazy<ILanguageService> _languageService;
        private readonly Lazy<IPersonalInfoService> _personalInfoService;
        private readonly Lazy<IPortfolioService> _portfolioService;
        private readonly Lazy<ISkillGroupService> _skillGroupService;
        private readonly Lazy<ISkillService> _skillService;
        private readonly Lazy<ISocialMediaService> _socialMediaService;

        public ServiceManager(IRepositoryManager repositoryManager,
            ILoggerManager logger)
        {
            _certificateService = new Lazy<ICertificateService>(() => new CertificateService(repositoryManager, logger));
            _contactService = new Lazy<IContactService>(() => new ContactService(repositoryManager, logger));
            _educationService = new Lazy<IEducationService>(() => new EducationService(repositoryManager,logger));
            _experienceService = new Lazy<IExperienceService>(() => new ExperienceService(repositoryManager, logger));
            _languageService = new Lazy<ILanguageService>(() => new LanguageService(repositoryManager, logger));
            _personalInfoService = new Lazy<IPersonalInfoService>(() => new PersonalInfoService(repositoryManager, logger));
            _portfolioService = new Lazy<IPortfolioService>(() => new PortfolioService(repositoryManager, logger));
            _skillGroupService = new Lazy<ISkillGroupService>(() => new SkillGroupService(repositoryManager, logger));
            _skillService = new Lazy<ISkillService>(()=> new SkillService(repositoryManager, logger));
            _socialMediaService = new Lazy<ISocialMediaService>(() => new SocialMediaService(repositoryManager, logger));
        }


        public ICertificateService CertificateService => _certificateService.Value;
        public IContactService ContactService => _contactService.Value;
        public IEducationService EducationService => _educationService.Value;
        public IExperienceService ExperienceService => _experienceService.Value;
        public ILanguageService LanguageService => _languageService.Value;
        public IPersonalInfoService PersonalInfoService => _personalInfoService.Value;
        public IPortfolioService PortfolioService => _portfolioService.Value;
        public ISkillService SkillService => _skillService.Value;
        public ISkillGroupService SkillGroupService => _skillGroupService.Value;
        public ISocialMediaService SocialMediaService => _socialMediaService.Value;
    }
}
