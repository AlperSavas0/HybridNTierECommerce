using HybridNTierECommerce.BLL.Services.Abstracts;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Services.Concretes
{
    public class SessionService : ISessionService
    {
        private readonly ISession _session;

        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        public void SetObject<T>(string key, T value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            _session.SetString(key, objectString);
        }
        public T GetObject<T>(string key) where T : class
        {
            string objectString = _session.GetString(key);
            if (!string.IsNullOrEmpty(objectString)) return JsonConvert.DeserializeObject<T>(objectString);
            return null;
        }
    }
}
