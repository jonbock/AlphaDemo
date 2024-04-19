using AlphaDemoWebApi.Model.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlphaDemoWebApi.Service.Interface.Logging
{
    public interface ILogItem
    {
        Task<List<ErrorLog>> GetErrorLog();
    }
}
