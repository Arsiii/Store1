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

namespace Store1.Forms
{
    public partial class Add_Employee : Form
    {
        Employee current = new Employee();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Home\Documents\mydatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda2 = new SqlDataAdapter();
        string stringcommand = "SELECT * FROM Employeetable";
        SqlCommand mycommand;

        DataTable dt2 = new DataTable();
        public Add_Employee()
        {
            InitializeComponent();
            mycommand = new SqlCommand(stringcommand, con);

        }



        private void Add_Employee_Load(object sender, EventArgs e)
        {
            //Form load karnay per Employee ka data show ho jai
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Employeetable", con);
            sda2.Fill(dt2);
            DatagridviewEmployee.DataSource = dt2;

        }

        private void Esearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Esearchby.Text=="Name")
            {
                //yahan pe firstname search hoga

                Erandomlabel.Text = "Enter Name :" ;
                Erandomlabel.Visible = true;
                Esearchname.Visible = true;
                EsearchNIC.Visible = false;
                EsearchSalaryfrom.Visible = false;
                EsearchSalaryTo.Visible = false;
                EsearchJoiningdatefrom.Visible = false;
                EsearchJoiningdateTO.Visible = false;
                EsearchGender.Visible = false;
                EsearchAge.Visible = false;
                EsearchEperiencefom.Visible = false;
                EsearchEperienceTo.Visible = false;
                Rs.Visible = false;
                Rs2.Visible = false;
                Eyearslabel.Visible = false;
                Eyears2label.Visible = false;
                Efromlabel.Visible = false;
                Etolabel.Visible = false;
                EsearchID.Visible = false;

               
            }
            else if (Esearchby.Text == "Age")
            {
                //yahan pe age search hogi
                Erandomlabel.Text = "Enter Age :";
                Erandomlabel.Visible = true;
                Esearchname.Visible = false;
                EsearchNIC.Visible = false;
                EsearchSalaryfrom.Visible = false;
                EsearchSalaryTo.Visible = false;
                EsearchJoiningdatefrom.Visible = false;
                EsearchJoiningdateTO.Visible = false;
                EsearchGender.Visible = false;
                EsearchAge.Visible = true;
                EsearchEperiencefom.Visible = false;
                EsearchEperienceTo.Visible = false;
                Rs.Visible = false;
                Rs2.Visible = false;
                Eyearslabel.Visible = false;
                Eyears2label.Visible = false;
                Efromlabel.Visible = false;
                Etolabel.Visible = false;
                EsearchID.Visible = false;
            }
            else if (Esearchby.Text == "Gender")
            {
                //yahan pe gender search hoga
                Erandomlabel.Text = "Enter Gender :";
                Erandomlabel.Visible = true;
                Esearchname.Visible = false;
                EsearchNIC.Visible = false;
                EsearchSalaryfrom.Visible = false;
                EsearchSalaryTo.Visible = false;
                EsearchJoiningdatefrom.Visible = false;
                EsearchJoiningdateTO.Visible = false;
                EsearchGender.Visible = true;
                EsearchAge.Visible = false;
                EsearchEperiencefom.Visible = false;
                EsearchEperienceTo.Visible = false;
                Rs.Visible = false;
                Rs2.Visible = false;
                Eyearslabel.Visible = false;
                Eyears2label.Visible = false;
                Efromlabel.Visible = false;
                Etolabel.Visible = false;
                EsearchID.Visible = false;
            }
            else if (Esearchby.Text == "N.I.C")
            {
                //yahan pe N.I.C search hoga
                Erandomlabel.Text = "Enter N.I.C :";
                Erandomlabel.Visible = true;
                Esearchname.Visible = false;
                EsearchNIC.Visible = true;
                EsearchSalaryfrom.Visible = false;
                EsearchSalaryTo.Visible = false;
                EsearchJoiningdatefrom.Visible = false;
                EsearchJoiningdateTO.Visible = false;
                EsearchGender.Visible = false;
                EsearchAge.Visible = false;
                EsearchEperiencefom.Visible = false;
                EsearchEperienceTo.Visible = false;
                Rs.Visible = false;
                Rs2.Visible = false;
                Eyearslabel.Visible = false;
                Eyears2label.Visible = false;
                Efromlabel.Visible = false;
                Etolabel.Visible = false;
                EsearchID.Visible = false;
            }
            else if (Esearchby.Text == "Experience")
            {
                //yahan pe experience search hoga
                Erandomlabel.Text = "Enter Experience :";
                Erandomlabel.Visible = true;
                Esearchname.Visible = false;
                EsearchNIC.Visible = false;
                EsearchSalaryfrom.Visible = false;
                EsearchSalaryTo.Visible = false;
                EsearchJoiningdatefrom.Visible = false;
                EsearchJoiningdateTO.Visible = false;
                EsearchGender.Visible = false;
                EsearchAge.Visible = false;
                EsearchEperiencefom.Visible = true;
                EsearchEperienceTo.Visible = true;
                Rs.Visible = false;
                Rs2.Visible = false;
                Eyearslabel.Visible = true;
                Eyears2label.Visible = true;
                Efromlabel.Visible = true;
                Etolabel.Visible = true;
                EsearchID.Visible = false;
            }
            else if (Esearchby.Text == "Joining-Date")
            {
                //yahan pe joining-date search hogi
                Erandomlabel.Text = "Enter Joining-Date :";
                Erandomlabel.Visible = true;
                Esearchname.Visible = false;
                EsearchNIC.Visible = false;
                EsearchSalaryfrom.Visible = false;
                EsearchSalaryTo.Visible = false;
                EsearchJoiningdatefrom.Visible = true;
                EsearchJoiningdateTO.Visible = true;
                EsearchGender.Visible = false;
                EsearchAge.Visible = false;
                EsearchEperiencefom.Visible = false;
                EsearchEperienceTo.Visible = false;
                Rs.Visible = false;
                Rs2.Visible = false;
                Eyearslabel.Visible = false;
                Eyears2label.Visible = false;
                Efromlabel.Visible = true;
                Etolabel.Visible = true;
                EsearchID.Visible = false;
            }
            else if (Esearchby.Text == "Salary")
            {
                //yahan pe salary search hogi
                Erandomlabel.Text = "Enter Salary :";
                Erandomlabel.Visible = true;
                Esearchname.Visible = false;
                EsearchNIC.Visible = false;
                EsearchSalaryfrom.Visible = true;
                EsearchSalaryTo.Visible = true;
                EsearchJoiningdatefrom.Visible = false;
                EsearchJoiningdateTO.Visible = false;
                EsearchGender.Visible = false;
                EsearchAge.Visible = false;
                EsearchEperiencefom.Visible = false;
                EsearchEperienceTo.Visible = false;
                Rs.Visible = true;
                Rs2.Visible = true;
                Eyearslabel.Visible = false;
                Eyears2label.Visible = false;
                Efromlabel.Visible = true;
                Etolabel.Visible = true;
                EsearchID.Visible = false;
            }
            else if (Esearchby.Text == "ID")
            {
                //yahan pe ID search hoga
                Erandomlabel.Text = "Enter ID :";
                Erandomlabel.Visible = true;
                Esearchname.Visible = false;
                EsearchNIC.Visible = false;
                EsearchSalaryfrom.Visible = false;
                EsearchSalaryTo.Visible = false;
                EsearchJoiningdatefrom.Visible = false;
                EsearchJoiningdateTO.Visible = false;
                EsearchGender.Visible = false;
                EsearchAge.Visible = false;
                EsearchEperiencefom.Visible = false;
                EsearchEperienceTo.Visible = false;
                Rs.Visible = false;
                Rs2.Visible = false;
                Eyearslabel.Visible = false;
                Eyears2label.Visible = false;
                Efromlabel.Visible = false;
                Etolabel.Visible = false;
                EsearchID.Visible = true;
            }
        }

        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            // yahan add data ko cancel kr raha hai
            Eaddname.Text = "";
            EaddPhone.Text = "";
            EaddAddress.Text = "";
            EaddNIC.Text = "";
            EaddSalary.Text = "";
            EaddExperience.Text = "";
            EaddJoiningdate.Text = "";
            EaddBonus.Text = "";
            EaddAge.Text = "";
            EaddGender.Text = "";
            EaddDOB.Text = "";
            EaddIsadmin.Text = "";
            EaddUsername.Text = "";
            EaddPassword.Text = "";
            EaddstarGender.Visible = false;
            EaddstarName.Visible = false;
            EaddstarNIC.Visible = false;
            EaddstarUsername.Visible = false;
            EaddstarPassword.Visible = false;
        }

        private void buttonEditCancel_Click(object sender, EventArgs e)
        {
            // yahan edit data ko cancel kr raha hai


            IDtoedit.Text = "";
            Nametoedit.Text = "";
            EeditName.Text = "";
            EeditPhone.Text = "";
            EeditAddress.Text = "";
            EeditNIC.Text = "";
            EeditSalary.Text = "";
            EeditExperience.Text = "";
            EeditJoiningdate.Text = "";
            EeditBonus.Text = "";
            EeditAge.Text = "";
            EeditGender.Text = "";
            EeditDOB.Text = "";
            EeditIsadmin.Text = "";
            EeditUsername.Text = "";
            EeditPassword.Text = "";
            EeditIsadmin.Checked = false;

            EeditstarGender.Visible = false;
            EeditstarName.Visible = false;
            EeditstarNIC.Visible = false;
            EeditstarUsername.Visible = false;
            EeditstarPassword.Visible = false;

            sda2.SelectCommand = mycommand;
           // sda2.Fill(dt2);
            DatagridviewEmployee.DataSource = dt2;


           
        }

        private void buttonDeleteCancel_Click(object sender, EventArgs e)
        {
            //yahan delete data cancel ho raha hai
            //grid view main vapis sara data a jaye
            DatagridviewEmployee.DataSource = null;
            DatagridviewEmployee.Rows.Clear();
            
            sda2.SelectCommand = mycommand;
            //sda2.Fill(dt2);
            DatagridviewEmployee.DataSource = dt2;
            EnametoDelete.Text = "";
            EidtoDelete.Text = "";
        }

        private void buttonSearchCancel_Click(object sender, EventArgs e)
        {
            Esearchname.Text = "";
            EsearchAge.Text = "";
            EsearchID.Text = "";
            EsearchNIC.Text = "";
            EsearchSalaryfrom.Text = "";
            EsearchSalaryTo.Text = "";
            //sirf grid view main vapis sara data a jaye ga
            
            sda2.SelectCommand = mycommand;
            //sda2.Fill(dt2);
            DatagridviewEmployee.DataSource = dt2;

        }

        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            //ye New employee add karnay ka code hay
            if (Eaddname.Text == "")
            {
                EaddstarName.Visible = true;
            }
            if (EaddGender.Text == "")
            {
                EaddstarGender.Visible = true;
            }
            if (EaddNIC.Text == "")
            {
                EaddstarNIC.Visible = true;
            }
            if (EaddUsername.Text == "")
            {
                EaddstarUsername.Visible = true;
            }
            if(EaddPassword.Text == "")
            {
                EaddstarPassword.Visible = true;
            }



            if (Eaddname.Text != "" && EaddGender.Text != "" && EaddNIC.Text != "" && EaddUsername.Text != "" && EaddPassword.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Employeetable (Ename,EPhone,EAddress,ENIC,ESalary,EExperience,EJoiningDate,EBonas,EAge,EGender,EDOB,IsAdmin,EUsername,EPassword) VALUES('" + Eaddname.Text + "', '" + EaddPhone.Text + "', '" + EaddAddress.Text + "', '" + EaddNIC.Text + "','" + EaddSalary.Text + "','" + EaddExperience.Text + "','" + EaddJoiningdate.Value +"','" + EaddBonus.Text+"','" + EaddAge.Text +"','" + EaddGender.Text +"','" + EaddDOB.Value +"','" + EaddIsadmin.Checked +"','" + EaddUsername.Text +"','" + EaddPassword.Text +"')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Row inserted !! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
                EaddstarGender.Visible = false;
                EaddstarName.Visible = false;
                EaddstarNIC.Visible = false;
                EaddstarUsername.Visible = false;
                EaddstarPassword.Visible = false;
                Eaddname.Text = "";
                EaddPhone.Text = "";
                EaddAddress.Text = "";
                EaddNIC.Text = "";
                EaddSalary.Text = "";
                EaddExperience.Text = "";
                EaddJoiningdate.Text = "";
                EaddBonus.Text = "";
                EaddAge.Text = "";
                EaddGender.Text = "";
                EaddDOB.Text = "";
                EaddIsadmin.Text = "";
                EaddUsername.Text = "";
                EaddPassword.Text = "";
                dt2.Clear();
                sda2.SelectCommand = mycommand;
                sda2.Fill(dt2);
                DatagridviewEmployee.DataSource = dt2;

            }
            else
            {
                MessageBox.Show("Enter Required Fields");
            }
            
        }

        private void Nametoedit_TextChanged(object sender, EventArgs e)
        {
            //ye Edit may Name search karnay ka code hay
            if (Nametoedit.Text != "")
            {
                SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Employeetable WHERE Ename='" + Nametoedit.Text + "'", con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                DatagridviewEmployee.DataSource = dt3;
            }
        }

        private void IDtoedit_TextChanged(object sender, EventArgs e)
        {
            //yahan id dalnay per employee ka sara data autofill ho janay ka code hay
            string tempidtocheck = IDtoedit.Text;
            bool emptyid = true;
            foreach (DataRow fulltable in dt2.Rows)
            {
                if (fulltable["Eid"].ToString().Equals(tempidtocheck))
                {
                    emptyid = false;
                   // MessageBox.Show("id gaib hay");
                }
            }

            if (IDtoedit.Text != "" && emptyid == false)
            {
                SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Employeetable WHERE Eid='" + IDtoedit.Text + "'", con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                //DatagridviewEmployee.DataSource = dt3;
                //employee.id = dt3.Rows[0][0];
                EeditName.Text = dt3.Rows[0][1].ToString();
                EeditPhone.Text = dt3.Rows[0][2].ToString();
                EeditAddress.Text = dt3.Rows[0][3].ToString();
                EeditNIC.Text = dt3.Rows[0][4].ToString();
                EeditSalary.Text = dt3.Rows[0][5].ToString();
                EeditExperience.Text = dt3.Rows[0][6].ToString();
                EeditJoiningdate.Value = Convert.ToDateTime(dt3.Rows[0][7]);
                EeditBonus.Text = dt3.Rows[0][8].ToString();
                EeditAge.Text = dt3.Rows[0][9].ToString();
                EeditGender.Text = dt3.Rows[0][10].ToString();
                EeditDOB.Value = Convert.ToDateTime(dt3.Rows[0][11]);
                EeditIsadmin.Checked = Convert.ToBoolean(dt3.Rows[0][12]);
                EeditUsername.Text = dt3.Rows[0][13].ToString();
                EeditPassword.Text = dt3.Rows[0][14].ToString();
            }
            else
            {
                EeditName.Text = "";
                EeditPhone.Text = "";
                EeditAddress.Text = "";
                EeditNIC.Text = "";
                EeditSalary.Text = "";
                EeditExperience.Text = "";
                EeditJoiningdate.Text = "";
                EeditBonus.Text = "";
                EeditAge.Text = "";
                EeditGender.Text = "";
                EeditDOB.Text = "";
                EeditIsadmin.Text = "";
                EeditUsername.Text = "";
                EeditPassword.Text = "";
                EeditIsadmin.Checked = false;
            }
        }

        private void buttonEditUpdate_Click(object sender, EventArgs e)
        {
            //ye code Employee ka data uptade honay ka code hay
            if (EeditName.Text == "")
            {
                EeditstarName.Visible = true;
            }
            else
            {
                EeditstarName.Visible = false;
            }
            if (EeditGender.Text == "")
            {
                EeditstarGender.Visible = true;
            }
            else
            {
                EeditstarGender.Visible = false;
            }
            if (EeditNIC.Text == "")
            {
                EeditstarNIC.Visible = true;
            }
            else
            {
                EeditstarNIC.Visible = false;
            }
            if (EeditUsername.Text == "")
            {
                EeditstarUsername.Visible = true;
            }
            else
            {
                EeditstarUsername.Visible = false;
            }
            if (EeditPassword.Text == "")
            {
                EeditstarPassword.Visible = true;
            }
            else
            {
                EeditstarPassword.Visible = false;
            }



            if (EeditName.Text != "" && EeditGender.Text != "" && EeditNIC.Text != "" && EeditUsername.Text != "" && EeditPassword.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Employeetable set Ename='" + EeditName.Text + "' , EPhone='" + EeditPhone.Text + "' , EAddress='" + EeditAddress.Text + "' , ENIC='" + EeditNIC.Text + "' , ESalary='" + EeditSalary.Text + "' , EExperience='" + EeditExperience.Text + "' , EJoiningDate='" + EeditJoiningdate.Value + "' , EBonas='" + EeditBonus.Text + "' , EAge='" + EeditAge.Text + "' , EGender='" + EeditGender.Text + "' , EDOB='" + EeditDOB.Value + "' , IsAdmin='" + EeditIsadmin.Checked + "' , EUsername='" + EeditUsername.Text + "' , EPassword='" + EeditPassword.Text + "' where Eid='" + IDtoedit.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                   dt2.Clear();
                    sda2.SelectCommand = mycommand;
                     sda2.Fill(dt2);
                    DatagridviewEmployee.DataSource = dt2;

                    MessageBox.Show("Edited !! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                EeditstarGender.Visible = false;
                EeditstarName.Visible = false;
                EeditstarNIC.Visible = false;
                EeditstarUsername.Visible = false;
                EeditstarPassword.Visible = false;
                IDtoedit.Text = "";
                Nametoedit.Text = "";
                EeditName.Text = "";
                EeditPhone.Text = "";
                EeditAddress.Text = "";
                EeditNIC.Text = "";
                EeditSalary.Text = "";
                EeditExperience.Text = "";
                EeditJoiningdate.Text = "";
                EeditBonus.Text = "";
                EeditAge.Text = "";
                EeditGender.Text = "";
                EeditDOB.Text = "";
                EeditIsadmin.Text = "";
                EeditUsername.Text = "";
                EeditPassword.Text = "";
                EeditIsadmin.Checked = false;
            }
            else
            {
                MessageBox.Show("Enter Required Fields");
            }
        }

        private void buttonDeletedelete_Click(object sender, EventArgs e)
        {
            //ye Employee ko delete karnay ka code hay
            string tempidtocheck = EidtoDelete.Text;
            bool emptyid = true;
            foreach (DataRow fulltable in dt2.Rows)
            {
                if (fulltable["Eid"].ToString().Equals(tempidtocheck))
                {
                    emptyid = false;
                    // MessageBox.Show("id gaib hay");
                }
            }

            if (EidtoDelete.Text != "" && emptyid == false)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Employeetable where Eid='" + EidtoDelete.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                dt2.Clear();
                sda2.SelectCommand = mycommand;
                sda2.Fill(dt2);
                DatagridviewEmployee.DataSource = dt2;
                MessageBox.Show("delete ho gya");

            }
            else
            {

                MessageBox.Show("Pease Enter an ID");
            }
        }

        private void buttonSearchsearch_Click(object sender, EventArgs e)
        {
            if (Esearchby.Text == "Name")
            {
                //yahan pe firstname search hoga
                if (Esearchname.Text != "")
                {

                    try
                    {
                        SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Employeetable where Ename='" + Esearchname.Text + "'", con);
                        DataTable dt3 = new DataTable();
                        sda3.Fill(dt3);
                        DatagridviewEmployee.DataSource = dt3;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter Required Fields");
                }
            }
            else if (Esearchby.Text == "Age")
            {
                //yahan pe age search hogi
                if (EsearchAge.Text != "")
                {

                    try
                    {
                        SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Employeetable where EAge='" + EsearchAge.Text + "'", con);
                        DataTable dt3 = new DataTable();
                        sda3.Fill(dt3);
                        DatagridviewEmployee.DataSource = dt3;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter Required Fields");
                }
                // EsearchAge.Visible = true;

            }
            else if (Esearchby.Text == "Gender")
            {
                //yahan pe gender search hoga
                if (EsearchGender.Text != "")
                {

                    try
                    {
                        SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Employeetable where EGender='" + EsearchGender.Text + "'", con);
                        DataTable dt3 = new DataTable();
                        sda3.Fill(dt3);
                        DatagridviewEmployee.DataSource = dt3;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter Required Fields");
                }
                // EsearchGender.Visible = true;
            }
            else if (Esearchby.Text == "N.I.C")
            {
                //yahan pe N.I.C search hoga
                if (EsearchNIC.Text != "")
                {

                    try
                    {
                        SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Employeetable where ENIC='" + EsearchNIC.Text + "'", con);
                        DataTable dt3 = new DataTable();
                        sda3.Fill(dt3);
                        DatagridviewEmployee.DataSource = dt3;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter Required Fields");
                }
                //  EsearchNIC.Visible = true;
            }
            else if (Esearchby.Text == "Experience")
            {
                //yahan pe experience search hoga
               // EsearchEperiencefom.Visible = true;
               // EsearchEperienceTo.Visible = true;
            }
            else if (Esearchby.Text == "Joining-Date")
            {
                //yahan pe joining-date search hogi
               // EsearchJoiningdatefrom.Visible = true;
               // EsearchJoiningdateTO.Visible = true;
            }
            else if (Esearchby.Text == "Salary")
            {
                //yahan pe salary search hogi
              //  EsearchSalaryfrom.Visible = true;
               // EsearchSalaryTo.Visible = true;
            }
            else if (Esearchby.Text == "ID")
            {
                //yahan pe ID search hoga
                if (EsearchID.Text != "")
                {

                    try
                    {
                        SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Employeetable where Eid='" + EsearchID.Text + "'", con);
                        DataTable dt3 = new DataTable();
                        sda3.Fill(dt3);
                        DatagridviewEmployee.DataSource = dt3;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Enter Required Fields");
                }
                //EsearchID.Visible = true;
            }
        }
    }
}
