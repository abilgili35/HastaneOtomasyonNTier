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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.Ignore(x => x.ID);

            builder.HasKey(x => new { x.DoctorId, x.PatientId });

            builder.HasOne(x => x.Doctor)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.DoctorId);

            builder.HasOne(x => x.Patient)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.PatientId);

            builder.Property(x => x.PatientId).IsRequired();
            builder.Property(x => x.DoctorId).IsRequired();
            builder.Property(x => x.AppointmentDate).IsRequired();

            builder.HasData(AppointmentSeed.Appointments);
        }
    }
}
