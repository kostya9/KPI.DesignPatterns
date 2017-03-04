using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Clinic
{
    public class Therapist : SimpleDoctor
    {
        public Therapist(string name) : base(name)
        {
        }

        public override void CheckPatient(Patient p)
        {
            Say($"Start checking overall health {p.Name}");
            Say(p.Temperature < 0.5f ? "Your head is hot. You are ill." : "In general cases, you are healthy.");
            Say($"Stop checking overall health {p.Name}");
        }
    }
}
