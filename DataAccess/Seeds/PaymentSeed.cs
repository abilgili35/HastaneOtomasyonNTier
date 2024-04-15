using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class PaymentSeed
    {
        public static List<Payment> Payments = new List<Payment>()
        {
           new Payment{ID=1,PatientId=2,PaymentDate=new DateTime(2024,2,2),Amount=2000.50M,CreatedDate=DateTime.Now,IsActive=true},
           new Payment{ID=2,PatientId=2,PaymentDate=new DateTime(2024,2,3),Amount=4000M,CreatedDate=DateTime.Now,IsActive=true},
           new Payment{ID=3,PatientId=1,PaymentDate=new DateTime(2024,2,21),Amount=6000.70M,CreatedDate=DateTime.Now,IsActive=true},
           new Payment{ID=4,PatientId=3,PaymentDate=new DateTime(2024,3,2),Amount=8500.50M,CreatedDate=DateTime.Now,IsActive=true},

        };
    }
}
