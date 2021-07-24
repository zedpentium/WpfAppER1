using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppER1.Model
{
    public class ToDo
    {

        readonly int _todoid; // i have underscore on theese private fields, to differentiante them visually
        string _description;
        bool _done;
        Person _assignee;

        public ToDo(int todoid, string description)
        {
 
            this._todoid = todoid; // Why? u can only set a readonly in constructor
            Description = description;

        }

        public int ToDoId
        {
            get { return _todoid; }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The in-value are Null/Empty or whitespace. Will not be stored.");
                }

                _description = value;
            }
        }

        public bool Done
        {
            get { return _done; }
            set { _done = value;}
        }

        public Person Assignee
        {
            get { return _assignee; }
            set { _assignee = value;}
        }


        public override string ToString()
        {
            return Description.ToString();
        }

    }
}
