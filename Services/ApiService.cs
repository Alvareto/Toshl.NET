using System;
using System.Collections.Generic;
using Toshl.DataObjects;
using Toshl.Interfaces;
using Toshl.Responses;

namespace Toshl.Services
{
    internal class ApiService : IApiService
    {
        private string key;

        public ApiService(string key)
        {
            this.key = key;
        }

        public ApiResponse Delete(string url)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(string url, List<KeyValuePair<string, string>> args)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Get(string url)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Get(string url, List<KeyValuePair<string, string>> args)
        {
            throw new NotImplementedException();
        }

        public TResponse Get<TResponse>(string url, List<KeyValuePair<string, string>> args)
        {
            throw new NotImplementedException();
        }

        public Session GetSession()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Post(string url)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Post(string url, List<KeyValuePair<string, string>> args, string data)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Put(string url)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Put(string url, List<KeyValuePair<string, string>> args, string data)
        {
            throw new NotImplementedException();
        }
    }
}