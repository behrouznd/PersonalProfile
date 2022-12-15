using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class EducationService : IEducationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public EducationService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
