using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Lab2.RegistrationForm
{
    public class RegistrationForm
    {

        private readonly List<int> _ids;
        private readonly List<string> _obligatoryFields;

        public RegistrationForm()
        {
            _obligatoryFields = new List<string>();
            _ids = new List<int>();
            SetUpObligatoryFields();
        }

        public bool Validate(string fieldName, string value)
        {
            if (_obligatoryFields.Contains(fieldName))
                return !string.IsNullOrWhiteSpace(value);

            return true;
        }

        public bool Validate(string fieldName, int? value)
        {
            if (_obligatoryFields.Contains(fieldName))
                return value != null && value != 0;

            return true;
        }

        protected virtual void SetUpObligatoryFields()
        {
            _obligatoryFields.Add("UserName");
            _obligatoryFields.Add("Password");
        }

        public bool IsChecked(string fieldName)
        {
            return _obligatoryFields.Contains(fieldName);
        }

        public int GetNextId()
        {
            var id = _ids.DefaultIfEmpty(0).Max() + 1;
            _ids.Add(id);
            return id;
        }

        public static RegistrationForm Default => new RegistrationForm();
    }
}
