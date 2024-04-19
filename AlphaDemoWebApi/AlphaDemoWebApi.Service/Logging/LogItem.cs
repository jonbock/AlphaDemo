using AlphaDemoWebApi.Model.Data;
using AlphaDemoWebApi.Respository.Interface.Logging;
using AlphaDemoWebApi.Service.Interface.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlphaDemoWebApi.Service.Logging
{
    public class LogItem : ILogItem
    {
        private readonly IErrorLogData errorLogData;

        public LogItem(IErrorLogData _errorLogData)
        {
            errorLogData = _errorLogData;
        }

        public async Task<List<ErrorLog>> GetErrorLog()
        {
            return await errorLogData.GetErrorLog();
        }
    }
}
