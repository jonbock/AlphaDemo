using AlphaDemoWebApi.Model.Data;
using AlphaDemoWebApi.Respository.Interface.Logging;
using AlphaDemoWebApi.Respository.MsSql;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaDemoWebApi.Respository.Logging
{
    public class ErrorLogData : IErrorLogData
    {
        public async Task<List<ErrorLog>> GetErrorLog()
        {
            var result = new List<ErrorLog>();
            var callResult = new List<ErrorLog>();

            using (var ctx = new DataMsSql())
            {
                ctx.Database.Connection.Open();
                ctx.Database.CommandTimeout = 950;//or whatever
                callResult = ctx.ErrorLogs.Take(10).OrderByDescending(x => x.errortime).ToList();

            }

            //result.Add(callResult);
            return await Task.FromResult(callResult);
        }
    }
}
