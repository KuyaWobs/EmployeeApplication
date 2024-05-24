using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTE = new PartTimeEmployee(Fname.Text, LastN.Text, DeptB.Text, JobT.Text);
            partTE.computeSalary(Convert.ToDouble(RPH.Text), Convert.ToInt32(THW.Text));

            DisFname.Text = partTE.FirstName;
            DisLname.Text = partTE.LastName;
            DisBSal.Text = Convert.ToString(partTE.BasicSalary);

        }
    }
}
