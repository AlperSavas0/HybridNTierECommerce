using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Services.Abstracts
{
    public interface ISessionService
    {
        void SetObject<T>(string key, T value);
        T GetObject<T>(string key) where T : class;
    }
}
