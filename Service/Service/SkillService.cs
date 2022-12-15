using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class SkillService : ISkillService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public SkillService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
