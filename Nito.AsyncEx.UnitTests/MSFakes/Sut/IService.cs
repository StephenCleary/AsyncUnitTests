using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut
{
    public interface IService
    {
        Task ReturnNothingAsync();
        Task<int> ReturnIntAsync();
        Task<bool> ReturnBoolAsync();
        Task<object> ReturnObjectAsync();
        Task<Task<int>> ReturnTaskOfIntAsync();
    }
}
