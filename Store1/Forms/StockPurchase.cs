using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storeapp.Forms
{
    public partial class StockPurchase : Form
    {
        public StockPurchase()
        {
            InitializeComponent();
        }

        private void EaddPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void Sedit_Click(object sender, EventArgs e)
        {

        }

        private void Edelete_Click(object sender, EventArgs e)
        {

        }

        private void Ssearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ssearchby.Text == "Stock ID")
            {
                //yahan pe stockid search hoga

                Srandomlabel.Text = "Enter Stock ID :";
                Srandomlabel.Visible = true;
                SsearchSockID.Visible = true;
                SsearchDistributerName.Visible = false;
                SsearchProductCode.Visible = false;
                SsearchProductName.Visible = false;
                SsearchEmployeename.Visible = false;
                SsearchExpirydatefrom.Visible = false;
                SsearchExpirydateTo.Visible = false;
                SsearchDeliverydatefrom.Visible = false;
                SsearchDeliverydateTo.Visible = false;
                buttonSsearchDebit.Visible = false;
                buttonSsearchCredit.Visible = false;
                Sfromlabel.Visible = false;
                Stolabel.Visible = false;
            }
            else if(Ssearchby.Text=="Distributer Name")
            {
                //yahan distributername search hoga

                Srandomlabel.Text = "Enter Distributer Name :";
                Srandomlabel.Visible = true;
                SsearchSockID.Visible = false;
                SsearchDistributerName.Visible = true;
                SsearchProductCode.Visible = false;
                SsearchProductName.Visible = false;
                SsearchEmployeename.Visible = false;
                SsearchExpirydatefrom.Visible = false;
                SsearchExpirydateTo.Visible = false;
                SsearchDeliverydatefrom.Visible = false;
                SsearchDeliverydateTo.Visible = false;
                buttonSsearchDebit.Visible = false;
                buttonSsearchCredit.Visible = false;
                Sfromlabel.Visible = false;
                Stolabel.Visible = false;
            }
            else if (Ssearchby.Text == "Product Code")
            {
                //yahan pcode search hoga

                Srandomlabel.Text = "Enter Product Code :";
                Srandomlabel.Visible = true;
                SsearchSockID.Visible = false;
                SsearchDistributerName.Visible = false;
                SsearchProductCode.Visible = true;
                SsearchProductName.Visible = false;
                SsearchEmployeename.Visible = false;
                SsearchExpirydatefrom.Visible = false;
                SsearchExpirydateTo.Visible = false;
                SsearchDeliverydatefrom.Visible = false;
                SsearchDeliverydateTo.Visible = false;
                buttonSsearchDebit.Visible = false;
                buttonSsearchCredit.Visible = false;
                Sfromlabel.Visible = false;
                Stolabel.Visible = false;
            }
            else if (Ssearchby.Text == "Product Name")
            {
                //yahan pname search hoga

                Srandomlabel.Text = "Enter Product Name :";
                Srandomlabel.Visible = true;
                SsearchSockID.Visible = false;
                SsearchDistributerName.Visible = false;
                SsearchProductCode.Visible = false;
                SsearchProductName.Visible = true;
                SsearchEmployeename.Visible = false;
                SsearchExpirydatefrom.Visible = false;
                SsearchExpirydateTo.Visible = false;
                SsearchDeliverydatefrom.Visible = false;
                SsearchDeliverydateTo.Visible = false;
                buttonSsearchDebit.Visible = false;
                buttonSsearchCredit.Visible = false;
                Sfromlabel.Visible = false;
                Stolabel.Visible = false;
            }
            else if (Ssearchby.Text == "Employee Name")
            {
                //yahan ename search hoga

                Srandomlabel.Text = "Enter Employee Name :";
                Srandomlabel.Visible = true;
                SsearchSockID.Visible = false;
                SsearchDistributerName.Visible = false;
                SsearchProductCode.Visible = false;
                SsearchProductName.Visible = false;
                SsearchEmployeename.Visible = true;
                SsearchExpirydatefrom.Visible = false;
                SsearchExpirydateTo.Visible = false;
                SsearchDeliverydatefrom.Visible = false;
                SsearchDeliverydateTo.Visible = false;
                buttonSsearchDebit.Visible = false;
                buttonSsearchCredit.Visible = false;
                Sfromlabel.Visible = false;
                Stolabel.Visible = false;
            }
            else if (Ssearchby.Text == "Expiry-Date")
            {
                //yahan expirydate search hoga

                Srandomlabel.Text = "Enter Expiry-Date :";
                Srandomlabel.Visible = true;
                SsearchSockID.Visible = false;
                SsearchDistributerName.Visible = false;
                SsearchProductCode.Visible = false;
                SsearchProductName.Visible = false;
                SsearchEmployeename.Visible = false;
                SsearchExpirydatefrom.Visible = true;
                SsearchExpirydateTo.Visible = true;
                SsearchDeliverydatefrom.Visible = false;
                SsearchDeliverydateTo.Visible = false;
                buttonSsearchDebit.Visible = false;
                buttonSsearchCredit.Visible = false;
                Sfromlabel.Visible = true;
                Stolabel.Visible = true;
            }
            else if (Ssearchby.Text == "Delivery-Date")
            {
                //yahan deliverydate search hoga

                Srandomlabel.Text = "Enter Delivery-Date :";
                Srandomlabel.Visible = true;
                SsearchSockID.Visible = false;
                SsearchDistributerName.Visible = false;
                SsearchProductCode.Visible = false;
                SsearchProductName.Visible = false;
                SsearchEmployeename.Visible = false;
                SsearchExpirydatefrom.Visible = false;
                SsearchExpirydateTo.Visible = false;
                SsearchDeliverydatefrom.Visible = true;
                SsearchDeliverydateTo.Visible = true;
                buttonSsearchDebit.Visible = false;
                buttonSsearchCredit.Visible = false;
                Sfromlabel.Visible = true;
                Stolabel.Visible = true;
            }
            else if (Ssearchby.Text == "Debit/Credit")
            {
                //yahan debit/credit search hoga

                Srandomlabel.Text = "Enter Debit/Credit :";
                Srandomlabel.Visible = true;
                SsearchSockID.Visible = false;
                SsearchDistributerName.Visible = false;
                SsearchProductCode.Visible = false;
                SsearchProductName.Visible = false;
                SsearchEmployeename.Visible = false;
                SsearchExpirydatefrom.Visible = false;
                SsearchExpirydateTo.Visible = false;
                SsearchDeliverydatefrom.Visible = false;
                SsearchDeliverydateTo.Visible = false;
                buttonSsearchDebit.Visible = true;
                buttonSsearchCredit.Visible = true;
                Sfromlabel.Visible = false;
                Stolabel.Visible = false;
            }
        }
    }
}
