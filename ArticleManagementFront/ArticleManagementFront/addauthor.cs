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
    public partial class addauthor : Form
    {
        Connect conn = new Connect();
        public addauthor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string AID,FN,LN;
                AID = textBox1.Text.ToString();
                FN = textBox1.Text.ToString();
                LN = textBox2.Text.ToString();

               
                SqlConnection connect = new SqlConnection(conn.connecString);
                connect.Open();
                string cmd = @"insert into addauthor(first_name,last_name) values('" + FN + "','" + LN + "')";
                SqlCommand cmdTxt = new SqlCommand(cmd, connect);
                cmdTxt.ExecuteNonQuery();
                MessageBox.Show("You have successfully added a New Author");

                connect.Close();
                connect.Dispose();
                this.Refresh();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addauthor_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)


        {
           /* SqlConnection connect = new SqlConnection(connecString);
            connect.Open();
            String sql = @"select * from addauthor";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataAdapter datapter = new SqlDataAdapter(cmd);
            DataTable dr = new DataTable();
            datapter.Fill(dr);
            dataGridView1.DataSource = new BindingSource(dr, null);
            connect.Close(); 
            */
        }
         public void Display()
        {
            try
            {
                SqlConnection connect = new SqlConnection(conn.connecString);
                connect.Open();
                String sql = @"select CONCAT(first_name, ',', last_name) AS name from addauthor";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                DataTable dr = new DataTable();
                datapter.Fill(dr);
                dataGridView1.DataSource = new BindingSource(dr, null);
                connect.Close(); 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
     

        }
    }
}
