using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab4.Students;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearRegression;

namespace KPI.DesignPatterns
{
    class StudentsWorld : World
    {
        protected override void RunIteration()
        {
            var students = new List<Student>()
            {
                new Student(2, "Alla", new DateTime(1990, 1, 1)),
                new Student(0, "Petya", new DateTime(2001, 3, 1)),
                new Student(100, "Vasya", new DateTime(2001, 1, 1)),
                new Student(99, "Bogdan", new DateTime(1995, 1, 1)),
                new Student(3, "Masha", new DateTime(1999, 1, 1))
            };

            var groupId = new Group(students, new IdSortStrategy());
            var groupName = new Group(students.ToList(), new NameSortStrategy());
            var groupBirth = new Group(students.ToList(), new BirthDateSortStrategy());

            Console.WriteLine("\nUnsorted students:");
            WriteStudents(groupId);

            Console.WriteLine("\nSorted by id");
            groupId.Sort();
            WriteStudents(groupId);

            Console.WriteLine("\nSorted by name");
            groupName.Sort();
            WriteStudents(groupName);

            Console.WriteLine("\nSorted by Birth Date");
            groupBirth.Sort();
            WriteStudents(groupBirth);

        }

        private void WriteStudents(Group group)
        {
            foreach (var student in group.Students)
            {
                Console.WriteLine(student);
            }
        }


    }
}
