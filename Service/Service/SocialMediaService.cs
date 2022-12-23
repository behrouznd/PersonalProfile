using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class SocialMediaService : ISocialMediaService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SocialMediaService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager,
            IMapper mapper)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
            this._mapper = mapper;
        }
    }
}
