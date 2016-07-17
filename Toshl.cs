using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toshl.Interfaces;
using Toshl.Services;

namespace Toshl
{
    public class Toshl
    {
        private IApiService ApiService { get; set; }

        public IAccountService Account { get; private set; }

        public Toshl(string key)
        {
            ApiService = new ApiService(key);
            Account = new AccountService(ApiService);
        }
    }
}
