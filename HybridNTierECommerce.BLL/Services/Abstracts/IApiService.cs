using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Services.Abstracts
{
    public interface IApiService
    {
        Task<(bool, string)> MakePostRequestAsync(string endpoint, object data);
    }
}
