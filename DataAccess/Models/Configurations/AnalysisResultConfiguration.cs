using DataAccess.Models.Entities;
using DataAccess.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Configurations
{
    public class AnalysisResultConfiguration : IEntityTypeConfiguration<AnalysisResult>
    {
        public void Configure(EntityTypeBuilder<AnalysisResult> builder)
        {
            builder.Property(x => x.FileLink).HasMaxLength(255);

            builder.Property(x => x.AnalysisDate).IsRequired();
            builder.Property(x => x.PatientId).IsRequired();
            builder.Property(x => x.FileLink).IsRequired();

            builder.HasData(AnalysisResultSeed.AnalysisResults);
        }
    }
}
