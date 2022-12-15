namespace Service.Contracts
{
    public interface IServiceManager
    {
        public ICertificateService  CertificateService { get;  }
        public IContactService  ContactService { get;  }
        public IEducationService EducationService { get;  }
        public IExperienceService ExperienceService { get;  }
        public ILanguageService LanguageService { get;  }
        public IPersonalInfoService PersonalInfoService { get;  }
        public IPortfolioService PortfolioService { get;  }
        public ISkillService SkillService { get;  }
        public ISkillGroupService SkillGroupService { get;  }
        public ISocialMediaService SocialMediaService { get;  }
    }
}
