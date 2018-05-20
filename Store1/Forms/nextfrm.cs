using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store1.Classes;
using Store1.Forms;

namespace Store1
{
    
    public partial class nextfrm : Form
    {
        Employee employee2 = new Employee();
        DataTable nextdt = new DataTable();
        public nextfrm(DataTable current)
        {
            InitializeComponent();
            nextdt = current;
            nextfrmgrid.DataSource = current;
            
        }

        private void nextfrm_Load(object sender, EventArgs e)
        {
            mylabel.Text = employee2.id.ToString();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            Add_Employee abc = new Add_Employee();
            abc.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
