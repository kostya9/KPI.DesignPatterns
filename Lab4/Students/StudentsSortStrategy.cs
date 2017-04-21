using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab4.Students
{
    public interface IStudentsSortStrategy
    {
        void Sort(List<Student> students);
    }
}
