using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4.Students
{
    public class Group
    {
        private readonly IStudentsSortStrategy _strategy;
        private readonly List<Student> _students;

        public IEnumerable<Student> Students => _students;

        public Group(List<Student> students, IStudentsSortStrategy strategy)
        {
            _strategy = strategy;
            _students = students;
        }

        public void Sort()
        {
            _strategy.Sort(_students);
        }

    }
}
