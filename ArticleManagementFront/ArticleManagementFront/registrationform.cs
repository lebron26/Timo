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


namespace ArticleManagementFront
{
    public partial class registrationform : Form
    {
        string connecString = @"Data Source =.\SQLEXPRESS; Initial Catalog = wonderdb; Integrated Security = True";

        public registrationform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string LU, LP;
                LU = textBox1.Text.ToString();
                LP = textBox2.Text.ToString();


                SqlConnection connect = new SqlConnection(connecString);
                connect.Open();
                string cmd = @"insert into addauth(login_user,login_pass) values('" + LU + "','" + LP + "')";
                SqlCommand cmdTxt = new SqlCommand(cmd, connect);
                cmdTxt.ExecuteNonQuery();
                MessageBox.Show("You have successfully registered!");

                connect.Close();
                connect.Dispose();
                this.Refresh();
                this.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationform_Load(object sender, EventArgs e)
        {

        }
    }
}
