using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class PortfolioService : IPortfolioService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public PortfolioService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
