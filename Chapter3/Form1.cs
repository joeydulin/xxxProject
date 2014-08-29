using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FormSalary
{
    public partial class Form1 : Form
    {
        private BindingSource myBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            SalarydataGridView.DataSource = myBindingSource;
        }

        private void buttonAddPersonnel_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            newEmployee.FirstName = tbFirstName.Text;
            newEmployee.LastName = tbLastName.Text;
            newEmployee.HireDate = dateTimePicker1.Value;
            newEmployee.Position = listBoxPosition.SelectedItem.ToString();
            
            myBindingSource.Add(newEmployee);
            pnpEmployee.Add(newEmployee);


           // tbFirstName.Text = "";
           // tbLastName.Text = "";

        }

        private void tbFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
        }
        List<Employee> pnpEmployee = new List<Employee>();
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var loadData = File.ReadAllText(@"C:\Users\MAGILAS\ExercisesVS\pnpEmployee.json");
            List<Employee> newpnpEmployee = JsonConvert.DeserializeObject <List<Employee>>(loadData);

            foreach (var employee in newpnpEmployee)
            {
                pnpEmployee.Add(employee);
                myBindingSource.Add(employee);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var myData = JsonConvert.SerializeObject(pnpEmployee);
            File.WriteAllText(@"C:\Users\MAGILAS\ExercisesVS\pnpEmployee.json", myData);

        }

        

        
    }
}
