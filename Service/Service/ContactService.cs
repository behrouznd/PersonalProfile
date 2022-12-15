﻿using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class ContactService : IContactService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ContactService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
        }
    }
}
