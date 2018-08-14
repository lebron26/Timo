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

    public partial class addcategory : Form
    {
        Connect conn = new Connect();
        public addcategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == " ")
            {
                MessageBox.Show("Please Enter a Category");

            }
    
            try
            {
                string categ;
                categ = textBox1.Text.ToString();
               
                SqlConnection connect = new SqlConnection(conn.connecString);
                connect.Open();

                string cmd = @"insert into addcategory(category_name) values('" + categ + "')";
                SqlCommand cmdTxt = new SqlCommand(cmd, connect);
                cmdTxt.ExecuteNonQuery();
                MessageBox.Show("Added a New Category!");

                connect.Close();
                connect.Dispose();
                this.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addcategory_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* SqlConnection connect = new SqlConnection(connecString);
            connect.Open();
            String sql = @"select * from addcategory";
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
                String sql = @"select category_name from addcategory";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataAdapter datapter = new SqlDataAdapter(cmd);
                DataTable dr = new DataTable();
                datapter.Fill(dr);
                dataGridView1.DataSource = new BindingSource(dr, null);
                dataGridView1.RowHeadersVisible = false;
                connect.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {

                    string id = dataGridView1.SelectedCells[0].Value.ToString();
                    SqlConnection connect1 = new SqlConnection(conn.connecString);
                    connect1.Open();
                    string query = "DELETE from addcategory where category_name= '"+ id + "'";
                    SqlDataAdapter cmmdtxt = new SqlDataAdapter(query, connect1);

                    cmmdtxt.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted the Category!");

                    connect1.Close();
                    connect1.Dispose();
                    this.Refresh();}
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
