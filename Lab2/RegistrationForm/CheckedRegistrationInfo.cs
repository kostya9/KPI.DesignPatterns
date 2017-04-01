using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.RegistrationForm
{
    public class CheckedRegistrationInfo : RegistrationInfo
    {
        private static RegistrationForm _form;
        public static RegistrationForm RegistrationForm
        {
            get { return _form ?? (_form = RegistrationForm.Default); }

            set { _form = value; }
        }


        public CheckedRegistrationInfo(string userName, string password, string name, int? age) :
            base(_form.GetNextId() , userName, password, name, age)
        {
            if (!_form.Validate("UserName", userName))
                throw new ArgumentException("Checked field is not specified");
            if (!_form.Validate("Password", password))
                throw new ArgumentException("Checked field is not specified");
            if (!_form.Validate("Name", name))
                throw new ArgumentException("Checked field is not specified");
            if (!_form.Validate("Age", age))
                throw new ArgumentException("Checked field is not specified");
        }

    }
}
