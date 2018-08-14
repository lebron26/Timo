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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            try
            {
                 SqlConnection connect = new SqlConnection(conn.connecString);

                string SqlLogin = @"SELECT COUNT(*) FROM addauth WHERE (login_user = '" + textBox1.Text + "' and login_pass = '" + textBox2.Text + "' )";
                SqlDataAdapter adapter = new SqlDataAdapter(SqlLogin, connect);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    main need = new main();
                    need.ShowDialog();
                }
                else
                    MessageBox.Show("Invalid username or password");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            about aboutme = new about();
            aboutme.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationform regform = new registrationform();
            regform.Show();
        }
    }
}
