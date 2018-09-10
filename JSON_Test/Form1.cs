using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSON_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.id = 22;
            emp.fname = "pushpa";
            emp.lname = "ghale";
            emp.dept = "information technology";

            string output = string.Empty;
            output += @"Serializing the object below
            Employee emp = new Employee();
            emp.id = 22;
            emp.fname = ""pushpa"";
            emp.lname = ""ghale"";
            emp.dept = ""information technology"";";

            output += "\n Below is serialized object \n";
            output += JsonConvert.SerializeObject(emp);
            textBox1.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string empJson = "{\"id\":22,\"fname\":\"pushpa\",\"lname\":\"ghale\",\"dept\":\"information technology\"}";

            var empobj = JsonConvert.DeserializeObject<Employee>(empJson);

            string output = string.Empty;
            output += "Deserializing Json string below and casting it to employee object \n";
            output += empJson + "\n";
            output += "fname property from the new object: " + empobj.fname;
            textBox1.Text = output;
        }
    }

    class Employee
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string dept { get; set; }
    }
}
