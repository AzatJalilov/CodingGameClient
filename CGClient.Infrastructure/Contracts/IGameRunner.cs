using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public interface IGameRunner
    {
        int Run(string code, int firstId, int secondId);
        Task<int> RunAsync(string code, int firstId, int secondId);
    }
}
