using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NetPromoterScore
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DE001V057;Initial Catalog=Operations;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'operationsDataSet.tbl_nps' table. You can move, or remove it, as needed.
            //this.tbl_npsTableAdapter.Fill(this.operationsDataSet.tbl_nps);
            // TODO: This line of code loads data into the 'testsqlDataSet1.nps_table' table. You can move, or remove it, as needed.
            DisplayData();

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            if (txt_Ticket_number.Text != "" && txt_Ticket_number.Text != "")
            {
                cmd = new SqlCommand("insert into tbl_nps([Ticket number], Customer, [Date of call], Technology, Score, Comment, Country, Username) values(@ticket, @customer, @date, @technology, @score, @comment, @country, SYSTEM_USER)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ticket", txt_Ticket_number.Text);
                cmd.Parameters.AddWithValue("@customer", txt_Customer.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@technology", txt_Technology.Text);
                cmd.Parameters.AddWithValue("@score", txt_Score.Text);
                cmd.Parameters.AddWithValue("@comment", txt_Comment.Text);
                cmd.Parameters.AddWithValue("@country", txt_Country.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }


        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_nps where username = SYSTEM_USER", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            txt_Ticket_number.Text = "";
            txt_Customer.Text = "";
            txt_Technology.Text = "";
            txt_Score.Text = "";
            txt_Comment.Text = "";
        }
        //Update Record  

        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Ticket_number.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (txt_Ticket_number != null)
            {
                cmd = new SqlCommand("delete tbl_nps where [Ticket number]=@ticket", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ticket", txt_Ticket_number.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Customer_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
