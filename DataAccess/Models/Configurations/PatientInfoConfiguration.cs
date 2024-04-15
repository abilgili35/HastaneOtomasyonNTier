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
    internal class PatientInfoConfiguration : IEntityTypeConfiguration<PatientInfo>
    {
        public void Configure(EntityTypeBuilder<PatientInfo> builder)
        {
            //builder.Property(x => x.BirthDate).IsRequired(false);
            //builder.Property(x => x.Weight).IsRequired(false);
            //builder.Property(x => x.Height).IsRequired(false);
            builder.Property(x => x.Email).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.PhoneNumber).IsRequired(false);

            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(255);
            builder.Property(x => x.PhoneNumber).HasMaxLength(11);

            builder.HasOne(x => x.Patient).WithOne(x => x.PatientInfo).HasForeignKey<PatientInfo>(x => x.ID);

            builder.HasData(PatientInfoSeed.PatientInfos);


        }
    }
}
