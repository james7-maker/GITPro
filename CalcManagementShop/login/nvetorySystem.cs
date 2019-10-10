
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login

{
    public partial class Form2: Form
    {
        string Order = "{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}";//specify column size

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.inventoryDataSet.CustomerDetails);
            FirstOutput.Items.Add(String.Format(Order, "ID", "Firstname", "Lastname", "Order", "Method Of Payment", "Date of Order", "Price"));
            cmbOrder.Items.Add("Select Order");
            cmbOrder.Items.Add("Inshop");
            cmbOrder.Items.Add("Online");
            cmbOrder.Items.Add("Telephone");

            cmbPayment.Items.Add("Select Type");
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Master Card");
            cmbPayment.Items.Add("Visa Card");
            cmbPayment.Items.Add("Debit Card");

            Product.Items.Add("Casio");
            Product.Items.Add("WriteView");
            Product.Items.Add("fx2zl");
            Product.Items.Add("Sharp");
            Product.Items.Add("Calculator Store");

            chkBasic.Checked = false;
            chkScientific.Checked = false;
            chkOther.Checked = false;
            chkFullset.Checked = false;

            rbTwo.Checked = false;
            rbFour.Checked = false;
            rbEight.Checked = false;
            rbTen.Checked = false;





        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullset.Checked)
            {
                chkBasic.Checked = true;
                chkScientific.Checked = true;
                chkOther.Checked = true;
            }
            else {
                chkBasic.Checked = false;
                chkScientific.Checked = false;
                chkOther.Checked = false;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm Exit", "InventorySystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();

            chkBasic.Checked = false;
            chkScientific.Checked = false;
            chkOther.Checked = false;
            chkFullset.Checked = false;

            rbTwo.Checked = false;
            rbFour.Checked = false;
            rbEight.Checked = false;
            rbTen.Checked = false;

            Product.Items.Clear();
            FirstOutput.Items.Clear();
            FirstOutput.Items.Add(String.Format(Order, "ID", "Firstname", "Lastname", "Order", "Method Of Payment", "Date of Order", "Price"));

            cmbOrder.Text = "Select Order";
            cmbPayment.Text = "Select Type";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();

            chkBasic.Checked = false;
            chkScientific.Checked = false;
            chkOther.Checked = false;
            chkFullset.Checked = false;

            rbTwo.Checked = false;
            rbFour.Checked = false;
            rbEight.Checked = false;
            rbTen.Checked = false;

            FirstOutput.Items.Clear();

            cmbOrder.Text = "Select Order";
            cmbPayment.Text = "Select Type";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string ID, Firstname, Lastname, SelectOrder, SelectType, SelectDate, Price;
            double Casio_Price = 35.0;
            double WriteView_Price = 27.8;
            double fx2zl_Price = 22.3;
            double Sharp_Price = 29.3;


            ID = txtCustomerID.Text;
            Firstname = txtFirstname.Text;
            Lastname = txtLastname.Text;
            SelectOrder = cmbOrder.Text;
            SelectType = cmbPayment.Text;
            SelectDate = dateTimePicker1.Text;

            if (Product.Text == "")
            {
                MessageBox.Show("You must Select a Product", "ProductName", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((chkBasic.Checked == false) && (chkScientific.Checked == false) && (chkOther.Checked == false) &&
                (chkFullset.Checked == false))
            {
                MessageBox.Show("You must Select a Class", "Class", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if ((rbTwo.Checked == false) && (rbFour.Checked == false) && (rbEight.Checked == false) && (rbTen.Checked == false))
            {
                MessageBox.Show("You must Select a quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);




                if (Product.Text == "Casio" && chkBasic.Checked == true && rbTwo.Checked == true)
                {
                    Price = String.Format("{0:$}", (Casio_Price * 1.98));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "Casio" && chkBasic.Checked == true && rbFour.Checked == true)
                {
                    Price = String.Format("{0:$}", (Casio_Price * 2.45));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "Casio" && chkBasic.Checked == true && rbEight.Checked == true)
                {
                    Price = String.Format("{0:$}", (Casio_Price * 4.14));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "Casio" && chkBasic.Checked == true && rbTen.Checked == true)
                {
                    Price = String.Format("{0:$}", (Casio_Price * 9.8));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }



                if (Product.Text == "WriteView" && chkBasic.Checked == true && rbTwo.Checked == true)
                {
                    Price = String.Format("{0:$}", (WriteView_Price * 1.75));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "WriteView" && chkBasic.Checked == true && rbFour.Checked == true)
                {
                    Price = String.Format("{0:$}", (WriteView_Price * 3.1));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "WriteView" && chkBasic.Checked == true && rbEight.Checked == true)
                {
                    Price = String.Format("{0:$}", (WriteView_Price * 7.2));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "WriteView" && chkBasic.Checked == true && rbTen.Checked == true)
                {
                    Price = String.Format("{0:$}", (WriteView_Price * 9.0));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));
                }




                if (Product.Text == "Sharp" && chkBasic.Checked == true && rbTwo.Checked == true)
                {
                    Price = String.Format("{0:$}", (Sharp_Price * 1.75));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "Sharp" && chkBasic.Checked == true && rbFour.Checked == true)
                {
                    Price = String.Format("{0:$}", (Sharp_Price * 6.61));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "Sharp" && chkBasic.Checked == true && rbEight.Checked == true)
                {
                    Price = String.Format("{0:$}", (Sharp_Price * 5.1));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "Sharp" && chkBasic.Checked == true && rbTen.Checked == true)
                {
                    Price = String.Format("{0:$}", (Sharp_Price * 9.5));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));
                }






                if (Product.Text == "fx2zl" && chkBasic.Checked == true && rbTwo.Checked == true)
                {
                    Price = String.Format("{0:$}", (fx2zl_Price * 1.04));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "fx2zl" && chkBasic.Checked == true && rbFour.Checked == true)
                {
                    Price = String.Format("{0:$}", (fx2zl_Price * 3.3));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "fx2zl" && chkBasic.Checked == true && rbEight.Checked == true)
                {
                    Price = String.Format("{0:$}", (fx2zl_Price * 4.67));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
                else if (Product.Text == "fx2zl" && chkBasic.Checked == true && rbTen.Checked == true)
                {
                    Price = String.Format("{0:$}", (fx2zl_Price * 8.5));
                    FirstOutput.Items.Add(String.Format(Order, ID, Firstname, Lastname, SelectOrder, SelectDate, Price));

                }
            }
        }
    }
}

