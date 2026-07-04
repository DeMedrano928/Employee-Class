namespace Employee_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Employee
        {
            // Class' Properties
            public string _name;
            public int _idNumber;
            public string _department;
            public string _position;

            // Constructor 
            public Employee(string name, int idNumber, string department, string position)
            {
                _name = name;
                _idNumber = idNumber;
                _department = department;
                _position = position;
            }

            // Constructor that takes only the Name and ID Number
            public Employee(string name, int idNumber)
            {
                _name = name;
                _idNumber = idNumber;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creates a list of employees with different properties.
            List<Employee> employees = new List<Employee>() {
                new Employee("Susan Meyers", 47899, "Account","Vice President"),
                new Employee("Mark Jones", 39119, "IT", "Programmer"),
                new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer"),
            };


            // Loops through all objects in the employee list.
            for (int i = 0; i < employees.Count; i++)
            {

                Employee currentEmployee = employees[i];

                // Displays all object properties in the text label.
                resultsLabel.Text += $"Object {i + 1}:" +
                    $"\n       Name: {currentEmployee._name}" +
                    $"\n       ID: {currentEmployee._idNumber}" +
                    $"\n       Dept: {currentEmployee._department}" +
                    $"\n       Position: {currentEmployee._position}\n";

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the program
            this.Close();
        }
    }
}