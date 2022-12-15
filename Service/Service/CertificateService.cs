using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class CertificateService : ICertificateService
    {
        private readonly IRepositoryManager  _repository;
        private readonly ILoggerManager _logger;

        public CertificateService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
