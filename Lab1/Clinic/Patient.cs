using System;
using System.Runtime.CompilerServices;
using System.Threading;
using MathNet.Numerics.Distributions;

namespace Lab1.Clinic
{
    public class Patient
    {
        private double _temperature;
        private double _teethHealth;
        private double _bonesHealth;

        public Patient(string name)
        {
            Name = name;
            Say("I'm alive!");
        }

        private void InititlizeHealthValues()
        {
            BonesHealth = RandomNormalizedValue();
            TeethHealth = RandomNormalizedValue();
            Temperature = RandomTemperature();
        }

        public string Name { get; }

        public double Temperature
        {
            get { return _temperature; }
            private set
            {
                _temperature = value;
                if(_temperature >= 37D)
                    Say("I feel pretty week today...");
            }
        }

        public double TeethHealth
        {
            get { return _teethHealth; }
            private set
            {
                _teethHealth = value;
                if(_teethHealth < 0.5D)
                    Say("My teeth kinda hurt...");
            }
        }

        public double BonesHealth
        {
            get { return _bonesHealth; }
            set
            {
                _bonesHealth = value;
                if(BonesHealth < 0.5D)
                    Say("My bones kinda hurt...");
            }
        }

        public void LiveDay(Random r)
        {
            InititlizeHealthValues();
            if (RandomHealthyChoice(r))
                BrushTeeth();
            if(RandomHealthyChoice(r))
                Excersize();
            if(RandomHealthyChoice(r))
                EatVitamins();
        }

        private bool RandomHealthyChoice(Random r)
        {
            return r.Next(3) == 0;
        }

        // Normal distribution
        private double RandomTemperature()
        {
            double mean = 36.6;
            double stdDev = 1;
            Normal distribution = new Normal(mean, stdDev);
            return distribution.Sample();
        }

        private double RandomNormalizedValue()
        {
            double mean = 0.6;
            double stdDev = 0.3;
            Normal distribution = new Normal(mean, stdDev);
            return distribution.Sample();
        }

        private void BrushTeeth()
        {
            Say("I'm gonna brush my teeth!");
            TeethHealth = 1;
        }

        private void Excersize()
        {
            Say("I'm gonna excersize!");
            BonesHealth = 1;
        }

        private void EatVitamins()
        {
            Say("I'm gonna eat vitamins!");
            Temperature = 36.6;
        }

        private void Say(string message)
        {
            Console.WriteLine($"{Name} : {message}");
        }

        public static double HealthyTemperature = 36.6;
        public static double HealthyBones = 1;
        public static double HealthyTeeth = 1;

    }
}