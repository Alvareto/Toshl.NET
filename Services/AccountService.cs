using System.Collections.Generic;
using Toshl.Interfaces;
using Toshl.QueryObjects;

namespace Toshl.Services
{
    internal class AccountService : IAccountService
    {
        private IApiService apiService;

        public AccountService(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public List<Account> List()
        {
            throw new System.NotImplementedException();
        }

        public List<Account> List(AccountParams obj)
        {
            
            throw new System.NotImplementedException();
        }

        public Account Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Account Add(Account a)
        {
            throw new System.NotImplementedException();
        }

        public Account Edit(Account a)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Move(int id, int position)
        {
            throw new System.NotImplementedException();
        }
    }
}