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
    public partial class addarticle : Form
    {
        Connect conn = new Connect();
        public addarticle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main form2 = new main();
            form2.Show();
            this.Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(conn.connecString);
            connect.Open();
            String sql = @"select * from addauthor";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataAdapter datapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            datapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
   
                comboBox1.Items.Add(dr["first_name"].ToString());
            }
            connect.Close();

            SqlConnection connect1 = new SqlConnection(conn.connecString);
            connect1.Open();
            String sql1 = @"select * from addcategory";
            SqlCommand cmd1 = new SqlCommand(sql1, connect1 );
            SqlDataAdapter datapter1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            datapter1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {

                comboBox2.Items.Add(dr1["category_name"].ToString());
            }
            connect1.Close();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addcategory addcat = new addcategory();
            addcat.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addauthor addauth = new addauthor();
            addauth.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main backmenu = new main();
            backmenu.Show();
            this.Close();
        }
    }
}
