using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class LanguageService: ILanguageService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public LanguageService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
