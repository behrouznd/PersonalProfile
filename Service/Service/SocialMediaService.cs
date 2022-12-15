using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class SocialMediaService : ISocialMediaService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public SocialMediaService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
