using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.RegistrationForm
{
    public class RegistrationInfo
    {
        public RegistrationInfo(int id, string userName, string password, string name, int? age)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Name = name;
            Age = age;
        }

        public int Id { get; }
        public string UserName { get; }
        public string Password { get; }
        public string Name { get; }
        public int? Age { get; }
    }
}
