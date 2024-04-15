using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class DoctorSeed
    {
        public static List<Doctor> Doctors = new List<Doctor>()
        {
           new Doctor{ID=1,FirstName="Ahmet",LastName="Yilmaz",Profession="Dahiliye",DegreeDate=new DateTime(1961,1,1),CreatedDate=DateTime.Now,IsActive=true},
           new Doctor{ID=2,FirstName="Enver",LastName="Akturk",Profession="Cerrahi",DegreeDate=new DateTime(1967,1,1),CreatedDate=DateTime.Now,IsActive=true},
           new Doctor{ID=3,FirstName="Rukiye",LastName="Bilgili",Profession="Kulak Burun Bogaz",DegreeDate=new DateTime(1981,1,1),CreatedDate=DateTime.Now,IsActive=true},
           new Doctor{ID=4,FirstName="Ufuk",LastName="Gunalp",Profession="Goz",DegreeDate=new DateTime(1987,1,1),CreatedDate=DateTime.Now,IsActive=true},

        };
    }
}
