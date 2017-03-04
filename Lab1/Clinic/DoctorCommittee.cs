using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra.Complex.Solvers;

namespace Lab1.Clinic
{
    public class DoctorCommittee : Doctor
    {
        private List<Doctor> _doctors;

        public DoctorCommittee(string name) : base(name)
        {
            _doctors = new List<Doctor>();
        }

        public override void CheckPatient(Patient p)
        {
            Say($"Start checking {p.Name}");
            foreach (var doctor in _doctors)
            {
                doctor.CheckPatient(p);
            }
            Say($"Stop checking {p.Name}");
        }

        public override void Add(Doctor doctor)
        {
            _doctors.Add(doctor);
        }

        public override void Remove(Doctor doctor)
        {
            _doctors.Remove(doctor);
        }
    }
}
