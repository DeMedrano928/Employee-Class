namespace Employee_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    $"\n       Name: {currentEmployee.Name}" +
                    $"\n       ID: {currentEmployee.IdNumber}" +
                    $"\n       Dept: {currentEmployee.Department}" +
                    $"\n       Position: {currentEmployee.Position}\n";

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the program
            this.Close();
        }
    }
}