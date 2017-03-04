using System;
using System.Collections.Generic;
using System.Text;
using KPI.DesignPatterns;
using Lab1.Clinic;

namespace KPI.DesignPatterns
{
    public class ClinicWorld : World
    {
        private List<Patient> _patients;
        private List<Doctor> _doctors;

        public ClinicWorld()
        {
            _patients = new List<Patient>()
            {
                new Patient("Kolya"),
                new Patient("Petya"),
                new Patient("Vasya")
            };

            _doctors = new List<Doctor>();
            var commitee = new DoctorCommittee("SmallDoctorsAssociation");
            commitee.Add(new Therapist("Mrs. Jane"));
            commitee.Add(new Surgeon("Mr Jared"));
            _doctors.Add(commitee);
            _doctors.Add(new Dentist("Mr. Gray"));
            Name = "Clinic";
        }


        protected override void RunIteration()
        {
            Say("People are living a day");
            var r = new Random();
            foreach (var patient in _patients)
            {
                patient.LiveDay(r);
                Console.WriteLine("");
            }

            Say("Doctors are examining");

            foreach (var doctor in _doctors)
            {
                Say($"Doctor {doctor.Name} is checking.");
                foreach (var patient in _patients)
                {
                    Console.WriteLine();
                    doctor.CheckPatient(patient);
                    Console.WriteLine();
                }
            }
        }

        private void Say(string message)
        {
            Console.WriteLine($"\n[{Name}] : {message}\n");
        }
    }
}
