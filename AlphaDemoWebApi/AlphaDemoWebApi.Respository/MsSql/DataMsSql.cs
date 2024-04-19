using AlphaDemoWebApi.Model.Data;
using System.Data.Entity;

namespace AlphaDemoWebApi.Respository.MsSql
{
    public partial class DataMsSql : DbContext
    {
        public DataMsSql()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
