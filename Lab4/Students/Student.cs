using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Students
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(int id, string name, DateTime birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return string.Format("Id: {1}\nName: {0}\nBirthDate: {2}", Name, Id, BirthDate);
        }
    }
}
