using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Class
{
    internal class Employee
    {
        // Class' Properties
        private string _name { get; set; }
        private int _idNumber { get; set; }
        private string _department { get; set; }
        private string _position { get; set; }

        // Constructor 
        public Employee(string e_name, int id, string e_department, string pos)
        {
            _name = e_name;
            _idNumber = id;
            _department = e_department;
            _position = pos;
        }

        // Constructor that takes only the Name and ID Number
        public Employee(string e_name, int id)
        {
            _name = e_name;
            _idNumber = id;
            _department = "";
            _position = "";
        }

        // No parameters constructor
        public Employee()
        {
            _name = "";
            _idNumber = 0;
            _department = "";
            _position = "";
        }

        // Name property
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        //  Id Number Property
        public int IdNumber
        {
            get { return _idNumber; }
            private set { _idNumber = value; }
        }

        // Department Property
        public string Department
        {
            get { return _department; }
            private set { _department = value; }
        }

        // Position Property
        public string Position
        {
            get { return _position; }
            private set { _position = value; }
        }
    }
}
