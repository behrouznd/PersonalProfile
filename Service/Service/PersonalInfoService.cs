using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObject;

namespace Service
{
    internal sealed class PersonalInfoService : IPersonalInfoService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PersonalInfoService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager,
            IMapper mapper)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
            this._mapper = mapper;
        }

        public PersonalInfoDto GetPersonalInfo(Guid languageId, bool trackChanges)
        {
            var language = _repository.Language.GetLanguage(languageId, trackChanges);
            if (language == null)
                throw new LanguageNotFoundException(languageId);
            var personaInfoFromDB = _repository.PersonalInfo.GetPersonalInfos(languageId, trackChanges).FirstOrDefault();
            var personalDto = _mapper.Map<PersonalInfoDto>(personaInfoFromDB);
            return personalDto;
        }

        public PersonalInfoDto CreatePersonalInfo(Guid languageId, PersonalInfoForCreationDto personalInfo, bool trackChanges)
        {
            var language = _repository.Language.GetLanguage(languageId,trackChanges);
            if (language == null)
                throw new LanguageNotFoundException(languageId);

            var PersonalInfoByLanguageId = _repository.PersonalInfo.GetPersonalInfos(languageId, trackChanges);
            if (PersonalInfoByLanguageId != null && PersonalInfoByLanguageId.Count() > 0)
                throw new Exception("PersonalInfo for this language is exists");

            var personalInfoEntity = _mapper.Map<PersonalInfo>(personalInfo);
            _repository.PersonalInfo.CreatePersonalInfoForLanguage(languageId, personalInfoEntity);
            _repository.Save();

            var PersonalInfoToReturn = _mapper.Map<PersonalInfoDto>(personalInfoEntity);
            return PersonalInfoToReturn;
        }

    }
}
