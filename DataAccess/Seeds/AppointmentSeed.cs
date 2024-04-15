using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class AppointmentSeed
    {
        public static List<Appointment> Appointments = new List<Appointment>()
        {
            new Appointment{DoctorId=1,PatientId=2,AppointmentDate=new DateTime(2024,3,4),CreatedDate=DateTime.Now,IsActive=true},
            new Appointment{DoctorId=2,PatientId=1,AppointmentDate=new DateTime(2024,3,20),CreatedDate=DateTime.Now,IsActive=true},
            new Appointment{DoctorId=3,PatientId=3,AppointmentDate=new DateTime(2024,4,4),CreatedDate=DateTime.Now,IsActive=true},


        };
    }
}
