using BusinessLogic.Repositories;
using DataAccess.Models.Entities;

namespace CA_HospitalAutomationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PatientRepository patientRepository = new PatientRepository();

            Console.WriteLine("---------------------- PATIENTS --------------------");

            foreach(Patient p in patientRepository.GetAll()) 
            {
                Console.WriteLine($"{p.ID} {p.FirstName} {p.LastName} {p.IdentityNumber}");
            }

            PatientInfoRepository patientInfoRepository = new PatientInfoRepository();

            Console.WriteLine("---------------------- PATIENTINFOS --------------------");

            foreach (PatientInfo p in patientInfoRepository.GetAll())
            {
                Console.WriteLine($"{p.ID} {p.BirthDate} {p.Email} {p.Address}");
            }

            DoctorRepository doctorRepository = new DoctorRepository();

            Console.WriteLine("---------------------- Doctors --------------------");

            foreach (Doctor d in doctorRepository.GetAll())
            {
                Console.WriteLine($"{d.ID} {d.FirstName} {d.LastName} {d.Profession}");
            }

            RoomRepository roomRepository = new RoomRepository();

            Console.WriteLine("---------------------- Rooms --------------------");

            foreach (Room r in roomRepository.GetAll())
            {
                Console.WriteLine($"{r.ID} {r.BuildingNumber} {r.FloorNumber} {r.RoomNumber}");
            }

            AppointmentRepository appointmentRepository = new AppointmentRepository();

            Console.WriteLine("---------------------- Appointments --------------------");

            foreach (Appointment a in appointmentRepository.GetAll())
            {
                Console.WriteLine($"{a.PatientId} {a.DoctorId} {a.AppointmentDate}");
            }

            PaymentRepository paymentRepository = new PaymentRepository();

            Console.WriteLine("---------------------- Payments --------------------");

            foreach (Payment p in paymentRepository.GetAll())
            {
                Console.WriteLine($"{p.ID} {p.PatientId} {p.PaymentDate} {p.Amount}");
            }

            AnalysisResultRepository analysisResultRepository = new AnalysisResultRepository();

            Console.WriteLine("---------------------- Analysis Results --------------------");

            foreach (AnalysisResult p in analysisResultRepository.GetAll())
            {
                Console.WriteLine($"{p.ID} {p.PatientId} {p.AnalysisDate} {p.FileLink}");
            }


        }
    }
}