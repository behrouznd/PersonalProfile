namespace Contracts
{
    public interface IRepositoryManager
    {
        ICertificateRepository Certificate { get; }
        IContactRepository Contact { get; }
        IEducationRepository Education { get; }
        IExperienceRepository Experience { get; }
        ILanguageRepository Language { get; }
        IPersonalInfoRepository PersonalInfo { get; }
        IPortfolioRepository Portfolio { get; } 
        ISkillGroupRepository SkillGroup { get; }
        ISkillRepository Skill { get; }
        ISocialMediaRepository SocialMedia { get; }
        void Save();
    }
}
