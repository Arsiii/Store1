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

namespace Store1.Forms
{
    public partial class ResetPass : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Home\Documents\mydatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter();
        public ResetPass()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Employeetable set EPassword='" + ENewPassword.Text + "' where EUsername='" + EUser.Text + "' and ENIC='" + ENIC.Text + "' and EPhone='" + EPhone.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                // sda.InsertCommand = new SqlCommand("INSERT INTO Employeetable (EPassword)  VALUES('" + ENewPassword.Text + "') [WHERE EUsername='" + EUser.Text + "' and E-NIC='" + ENIC.Text + "' and E-Phone='" + EPhone.Text + "']", con);
                //sda.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Row inserted !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Employeetable WHERE EUsername='" + EUser.Text + "'", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Employeetable set EPassword='" + ENewPassword.Text + "' where EUsername='" + EUser.Text + "' and ENIC='" + ENIC.Text + "' and EPhone='" + EPhone.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
               
               // sda.InsertCommand = new SqlCommand("INSERT INTO Employeetable (EPassword)  VALUES('" + ENewPassword.Text + "') [WHERE EUsername='" + EUser.Text + "' and E-NIC='" + ENIC.Text + "' and E-Phone='" + EPhone.Text + "']", con);
                //sda.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Row inserted !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
