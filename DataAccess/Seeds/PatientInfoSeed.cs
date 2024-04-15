using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class PatientInfoSeed
    {
        public static List<PatientInfo> PatientInfos = new List<PatientInfo>()
        {
           new PatientInfo{ID=1,BirthDate=new DateTime(1961,2,8),Height=1.76,Weight=80.5,Email="info@abc.com",PhoneNumber="1112223344",CreatedDate=DateTime.Now,IsActive=true},
           new PatientInfo{ID=2,BirthDate=new DateTime(1981,2,8),Height=1.82,Weight=71.5,Email="info@bcd.com",PhoneNumber="1112223344",CreatedDate=DateTime.Now,IsActive=true},
           new PatientInfo{ID=3,BirthDate=new DateTime(1995,2,8),Height=1.90,Weight=82.5,Email="info@cde.com",PhoneNumber="1112223344",CreatedDate=DateTime.Now,IsActive=true},
           

        };
    }
}
