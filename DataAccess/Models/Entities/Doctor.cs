using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Doctor:BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public DateTime DegreeDate { get; set; }

        public virtual List<Appointment> Appointments { get; set; }
        public virtual Room Room { get; set; }
    }
}
