using System;
using System.Collections.Generic;
using System.Text;

using Lab2.RegistrationForm;

namespace KPI.DesignPatterns
{
    class RegistrationFormWorld : World
    {
        private RegistrationForm _form;

        public RegistrationFormWorld()
        {
            this._form = new RegistrationForm();
        }

        private string GetCheckedSymbol(bool isChecked)
        {
            return isChecked ? "*" : "";
        }

        protected override void RunIteration()
        {
            Console.WriteLine("Type in your registration info, please.");

            bool isChecked = CheckedRegistrationInfo.RegistrationForm.IsChecked("UserName");
            Console.WriteLine($"Type in your username{GetCheckedSymbol(isChecked)}, please");
            var userName = Console.ReadLine();

            isChecked = CheckedRegistrationInfo.RegistrationForm.IsChecked("Password");
            Console.WriteLine($"Type in your password{GetCheckedSymbol(isChecked)}, please");
            var password = Console.ReadLine();

            isChecked = CheckedRegistrationInfo.RegistrationForm.IsChecked("Name");
            Console.WriteLine($"Type in your name{GetCheckedSymbol(isChecked)}, please");
            var name = Console.ReadLine();

            isChecked = CheckedRegistrationInfo.RegistrationForm.IsChecked("Age");
            Console.WriteLine($"Type in your age{GetCheckedSymbol(isChecked)}, please");
            int.TryParse(Console.ReadLine(), out int age);

            RegistrationInfo info;

            try
            {
                info = new CheckedRegistrationInfo(userName, password, name, age);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Sorry, can't create a user because you did not specify all checked fields");
                return;
            }

            Console.WriteLine($"Successful! Your id is {info.Id}");
        }
    }
}
