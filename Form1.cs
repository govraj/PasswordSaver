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

namespace PasswordSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     /*----------------Function to submit website password detail in database-----------------------------*/

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtWeb.Text=="" || txtPass.Text=="" || txtCPass.Text=="")
            {
                lblError.Text = "Error: Please enter the value in all field";
            }
            else if(txtPass.Text!=txtCPass.Text)
            {
                lblError.Text = "Error: Password and Confirm Password should be same";
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=ASUS-PC\\SQLEXPRESS;Initial Catalog=PS;Integrated Security=sspi");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into PasswordSaver (Website,Password) values('" + txtWeb.Text + "','" + txtPass.Text + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                txtWeb.Text = "";
                txtPass.Text = "";
                txtCPass.Text = "";
                lblError.Text = "Record Submit Successfully!";
            }
        }

      /*----------------------Function to navigate on GetPassword window by clicking link------------------------*/

        private void linkGetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GetPassword GPass = new GetPassword();
            GPass.ShowDialog();
            
        }
    }
}
