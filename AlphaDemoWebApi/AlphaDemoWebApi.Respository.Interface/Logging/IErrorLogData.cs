using AlphaDemoWebApi.Model.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlphaDemoWebApi.Respository.Interface.Logging
{
    public interface IErrorLogData
    {
        Task<List<ErrorLog>> GetErrorLog();
    }
}
