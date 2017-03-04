using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Clinic
{
    public class Surgeon : SimpleDoctor
    {
        public Surgeon(string name) : base(name)
        {
        }

        public override void CheckPatient(Patient p)
        {
            Say($"Start checking bones {p.Name}");
            Say(p.BonesHealth < 0.5f ? "You need to excersize more. Your bones are in a bad spot." : "Your bones are healthy.");
            Say($"Stop checking bones {p.Name}");
        }
    }
}
