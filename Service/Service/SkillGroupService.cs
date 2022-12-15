using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class SkillGroupService : ISkillGroupService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public SkillGroupService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
