using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Students
{
    public class NameSortStrategy : IStudentsSortStrategy
    {
        public void Sort(List<Student> students)
        {
            students.Sort((s1, s2) => String.Compare(s1.Name, s2.Name, StringComparison.Ordinal));
        }
    }
}
