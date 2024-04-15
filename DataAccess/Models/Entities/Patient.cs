using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Patient : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdentityNumber { get; set; }

        public virtual PatientInfo PatientInfo { get; set; }
        public virtual List<Appointment> Appointments { get; set; }
        public virtual List<AnalysisResult> AnalysisResults { get; set; }
        public virtual List<Payment> Payments { get; set; }


    }
}

