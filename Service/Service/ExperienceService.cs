using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class ExperienceService : IExperienceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ExperienceService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
