using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class Employee
    {
        private int empId;
        private string firstName;
        private string lastName;
        private DateOnly dob;
        private string email;

        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                this.empId = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                Validate("FirstName", value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                Validate("LastName", value);
                this.lastName = value;
            }
        }

        public DateOnly Dob
        {
            get
            {
                return dob;
            }
            set
            {
                Validate("DOB", value.ToString());
                this.dob = value;
            }
        }

        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                Validate("Email", value);
                this.email = value;
            }
        }

        private void Validate(string paramName, string paramValue)
        {
            if (String.IsNullOrEmpty(paramValue))
            {
                throw new Exception(String.Format("{0} Should not be null / empty", paramName));
            }
        }

    }
}
