using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class PatientSeed
    {
        public static List<Patient> Patients = new List<Patient>()
        {
           new Patient{ID=1,FirstName="Ali",LastName="Yilmaz",IdentityNumber=333222111,CreatedDate=DateTime.Now,IsActive=true},
           new Patient{ID=2,FirstName="Osman",LastName="Akturk",IdentityNumber=55544433,CreatedDate=DateTime.Now,IsActive=true},
           new Patient{ID=3,FirstName="Aziz",LastName="Bilgili",IdentityNumber=66677788,CreatedDate=DateTime.Now,IsActive=true},
           new Patient{ID=4,FirstName="Fatih",LastName="Gunalp",IdentityNumber=22255588,CreatedDate=DateTime.Now,IsActive=true},

        };
    }
}
