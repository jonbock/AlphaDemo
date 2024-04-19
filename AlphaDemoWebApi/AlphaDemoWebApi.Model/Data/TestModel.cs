using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaDemoWebApi.Model.Data
{
    public class ErrorLog
    {
        public int id { get; set; }

        [StringLength(50)]
        public string application { get; set; }

        public string message { get; set; }

        [Column(TypeName = "text")]
        public string errorstack { get; set; }

        public DateTime? errortime { get; set; }

        public string notes { get; set; }
    }
}
