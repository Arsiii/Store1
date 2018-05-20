using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Store1.Classes;
using Store1.Forms;

namespace Store1
{

   
    public partial class FrmLogin : Form
    {
        Employee employee = new Employee();

        //public object id, salary, bonas;
        //public object age;
        //public object fname, lname, phone, address, nic, exprience, gender, user, pass;
        //public object joiningdate, DOB;
        //public object isadmin;


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Home\Documents\mydatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM Employeetable WHERE EUsername='" + Username.Text + "' and EPassword='" + Password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           

            
            //label2.Text = Convert.ToString(id);
            //label3.Text = Convert.ToString(fname);
            //label4.Text = Convert.ToString(lname);
           


            //Usernamelabel.Text = dt.Rows[0][13].ToString();
            //if (Admin.Checked == true )
            if (dt.Rows[0][0].ToString() == "1")//  & dt2.Rows[0][13].ToString() == Admin.Checked.ToString())
            {
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Employeetable WHERE EUsername='" + Username.Text + "' and EPassword='" + Password.Text + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);

                dataGridView1.DataSource = dt2;

                employee.id = dt2.Rows[0][0];
                employee.name = dt2.Rows[0][1];
                employee.isadmin = dt2.Rows[0][12];
                employee.phone = dt2.Rows[0][2];
                employee.address = dt2.Rows[0][3];
                employee.nic = dt2.Rows[0][4];
                employee.salary = dt2.Rows[0][5];
                employee.exprience = dt2.Rows[0][6];
                employee.joiningdate = dt2.Rows[0][7];
                employee.bonas = dt2.Rows[0][8];
                employee.age = dt2.Rows[0][9];
                employee.gender = dt2.Rows[0][10];
                employee.DOB = dt2.Rows[0][11];
                employee.user = dt2.Rows[0][13];
                employee.pass = dt2.Rows[0][14];

                if (Admin.Checked == true && employee.isadmin.ToString() == "True")
                {
                    //You are admin
                    //Admin kay agay janay wala code

                    nextfrm nf = new nextfrm(dt2);
                    nf.Show();
                    this.Hide();

                    MessageBox.Show("You are in database and admin ");
                    return;
                }
                else if (Employee.Checked == true && employee.isadmin.ToString() == "False")
                {
                    //you are employee
                    //Employee kay agay janay wala code
                    MessageBox.Show("You are in database and Employee ");
                    return;
                }
                else
                {
                    //Database may hay lekin option galat select kiya hoa hay
                    MessageBox.Show("Select Correct Option (Admin/Employee) ");
                    return;
                }
            }
            else
            {
                //Username ya Password galat hay
                MessageBox.Show("Enter Correct Username and Password ");
                return;
            }
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            ResetPass abc = new ResetPass();
            abc.Show();
        }


    }
}
