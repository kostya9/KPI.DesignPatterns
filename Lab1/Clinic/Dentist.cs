using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Clinic
{
    public class Dentist : SimpleDoctor
    {
        public Dentist(string name) : base(name)
        {
        }

        public override void CheckPatient(Patient p)
        {
            Say($"Start checking teeth {p.Name}");
            Say(p.TeethHealth < 0.5f ? "You have tooth decay." : "Your teeth are healthy.");
            Say($"End checking teeth {p.Name}");
        }
    }
}
