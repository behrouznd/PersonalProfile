using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObject;

namespace Service
{
    internal sealed class LanguageService: ILanguageService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LanguageService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager,
            IMapper mapper)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
            this._mapper = mapper;
        }

   
        public IEnumerable<LanguageDto> GetAllLanguages(bool trackChanges)
        {
            try
            {
                var languages = _repository.Language.GetAllLanguages(trackChanges);
                var langiagesDto = _mapper.Map<IEnumerable<LanguageDto>>(languages);
                return langiagesDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllLanguages)} service method {ex}");

                throw;
            }
        }
    }
}
