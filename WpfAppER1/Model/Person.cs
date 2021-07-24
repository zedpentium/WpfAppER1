using System;
using System.Collections.Generic;
using System.Text;
using WpfAppER1.Data;
using WpfAppER1.Model;

namespace WpfAppER1
{
    public class Person
    {

        private readonly int _personId;  // i have underscore on theese private fields, to differentiante them visually
        private string _firstName;
        private string _lastName;


        public Person(string firstName, string lastName, int personId)
        {
            this._personId = personId;
            FirstName = firstName;
            LastName = lastName;
        }


        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The in-value are Null/Empty or whitespace. Will not be stored.");
                }

                _firstName = value;
            }
        }


        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The in-value are Null/Empty or whitespace. Will not be stored.");
                }

                _lastName = value;
            }
        }

        public int PersonId
        {
            get { return _personId; }
        }


        public override string ToString()
        {
            return FirstName + " " + LastName.ToString();
        }
    }
}
