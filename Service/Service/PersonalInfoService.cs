using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class PersonalInfoService : IPersonalInfoService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public PersonalInfoService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
