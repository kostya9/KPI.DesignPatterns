using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Students
{
    public class IdSortStrategy : IStudentsSortStrategy
    {
        public void Sort(List<Student> students)
        {
            students.Sort((s1, s2) => s1.Id.CompareTo(s2.Id));
        }
    }
}
