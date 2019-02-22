using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteReadSequentalFile3
{
    [Serializable]
    public class Patient
    {
        public int SIN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Patient()
        { }

        public Patient(int SIN, string fName, string lName, int age)
        {
            this.SIN = SIN;
            FirstName = fName;
            LastName = lName;
            Age = age;
        }

        public override string ToString()
        {
            return String.Format($"SIN: {SIN.ToString()}, First Name: {FirstName}, Last Name: {LastName}, Age: {Age.ToString()}");
        }
    }
}
