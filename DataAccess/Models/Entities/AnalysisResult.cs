using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class AnalysisResult:BaseClass
    {
        public int PatientId { get; set; }
        public DateTime AnalysisDate { get; set; }
        public string FileLink { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
