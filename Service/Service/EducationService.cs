using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObject;

namespace Service
{
    internal sealed class EducationService : IEducationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public EducationService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager,
            IMapper mapper)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<EducationDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids == null)
                throw new IdParametersBadRequestException();

            var educationsEntity = _repository.Education.GetByIds(ids, trackChanges);
            if(ids.Count() != educationsEntity.Count())
                throw new CollectionByIdsBadRequestException();

            var educationsDto = _mapper.Map<IEnumerable<EducationDto>>(educationsEntity);
            return educationsDto;
        }

        public void DeleteEducationForPersonalInfo(Guid personalInfoId, Guid id, bool trackChanges)
        {
            var personalInfo = _repository.PersonalInfo.GetPersonalInfos(personalInfoId, trackChanges);
            if (personalInfo == null)
                throw new PersonalInfoNotFoundException(personalInfoId);

            var educationEntity = _repository.Education.GetEducation(id, trackChanges);
            if(educationEntity == null)
                throw new EducationNotFoundException(id);

            _repository.Education.DeleteEducation(educationEntity);
            _repository.Save();

        }
    }
}
