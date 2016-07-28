using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public interface IWebApi 
    {
        T Post<T>(string endPoint, object[] parameters);
        Task<T> PostAsync<T>(string endPoint, object[] parameters);
    }
}
