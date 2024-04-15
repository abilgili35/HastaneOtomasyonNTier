using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class AnalysisResultSeed
    {
        public static List<AnalysisResult> AnalysisResults = new List<AnalysisResult>()
        {
            new AnalysisResult{ID=1,PatientId=2,AnalysisDate=new DateTime(2024,2,21),FileLink="Link1",CreatedDate=DateTime.Now,IsActive=true},
            new AnalysisResult{ID=2,PatientId=1,AnalysisDate=new DateTime(2024,3,11),FileLink="Link2",CreatedDate=DateTime.Now,IsActive=true},
            new AnalysisResult{ID=3,PatientId=3,AnalysisDate=new DateTime(2024,2,10),FileLink="Link3",CreatedDate=DateTime.Now,IsActive=true},


        };
    }
}
