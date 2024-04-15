using DataAccess.Models.Configurations;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Context
{
    public class HospitalAutomationContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientInfo> PatientInfos { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<AnalysisResult> AnalysisResults { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=ABILGILI\\SQLEXPRESS;database=HospitalAutomationNTier;Integrated Security=SSPI;TrustServerCertificate=true");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientInfoConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new  AnalysisResultConfiguration()); 
            modelBuilder.ApplyConfiguration(new RoomConfiguration());

            

            base.OnModelCreating(modelBuilder);
        }

    }
}
