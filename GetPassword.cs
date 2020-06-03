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
    public partial class GetPassword : Form
    {
        public GetPassword()
        {
            InitializeComponent();
            RefreshData();
        }

     //------------------ Function to bind data in ComboBox ------------------------
        public void RefreshData()
        {
            // Create Data Row
            DataRow dr;

            // Create Connection and Execute query
            SqlConnection con = new SqlConnection("Data Source=ASUS-PC\\SQLEXPRESS;Initial Catalog=PS;Integrated Security=sspi");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from PasswordSaver", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Website--" };
            dt.Rows.InsertAt(dr, 0);

            //Bind the values
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Website";
            comboBox1.DataSource = dt;

            con.Close();

        }

     //------------- Function to get password by selecting website from ComboBox---------------------------

        private void btnGetPass_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                lblMsg.Text = "Please Select Website!";
            }
            else
            {
                lblMsg.Text = "";
                int Id = Convert.ToInt32(comboBox1.SelectedValue);

                // Create Connection and Execute query
                SqlConnection con = new SqlConnection("Data Source=ASUS-PC\\SQLEXPRESS;Initial Catalog=PS;Integrated Security=sspi");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Password from PasswordSaver where Id="+Id+"", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblPass2.Text = dt.Rows[0][0].ToString();

                }
            }
        }
     //-----------------------Function to navigate on save password window by clicking link-------------------------------------

        private void link_SavePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 savePass = new Form1();
            savePass.ShowDialog();
            

        }
     //-----------------------Function to Delete password record in Database----------------------------------------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete Record
            if (comboBox1.SelectedIndex == 0)
            {
                lblMsg.Text = "Please Select Website!";
            }
            else
            {
                lblMsg.Text = "";
                int Id = Convert.ToInt32(comboBox1.SelectedValue);

                // Create Connection and Execute query
                SqlConnection con = new SqlConnection("Data Source=ASUS-PC\\SQLEXPRESS;Initial Catalog=PS;Integrated Security=sspi");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from PasswordSaver where Id=" + Id + "", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                lblMsg.Text = "Record Deleted Succesfully!";
                lblPass2.Text = "";
             //------------Call RefreshData Function to bind current data after deleting record in database!--------------------------
                RefreshData();
                
            }
        }
    }
}
