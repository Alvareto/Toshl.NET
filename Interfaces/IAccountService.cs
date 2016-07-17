using System.Collections.Generic;

namespace Toshl.Interfaces
{
    public interface IAccountService
    {
        /// <summary>
        /// Get all users accounts.
        /// </summary>
        /// <returns></returns>
        List<Account> List();
        /// <summary>
        /// Get all users accounts.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        List<Account> List(QueryObjects.AccountParams obj);

        Account Get(int id);

        Account Add(Account a);

        Account Edit(Account a);

        bool Delete(int id);

        /// <summary>
        /// 
        /// https://developer.toshl.com/docs/accounts/move/move/
        /// </summary>
        /// <param name="id"></param>
        /// <param name="position">New account position. Minimum: &gt;= 0</param>
        /// <returns></returns>
        bool Move(int id, int position);
    }
}