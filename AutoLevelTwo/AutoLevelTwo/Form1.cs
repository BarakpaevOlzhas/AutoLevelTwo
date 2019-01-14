using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLevelTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string connectionString = "Data Source=localhost;Integrated Security=True"; //Initial Catalog = UserBase;

            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    sqlConnection.Open();
            //    string testInsert = "create database UserBase";
            //    SqlCommand sqlCommand = new SqlCommand(testInsert, sqlConnection);
            //    SqlDataReader dataReader = sqlCommand.ExecuteReader();
            //    sqlConnection.Close();
            //}

            //using (SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog = UserBase;Integrated Security=True"))
            //{
            //    sqlConnection.Open();
            //    string TwoCommand = "CREATE TABLE Users (Id int PRIMARY KEY, Login nvarchar(100),Password nvarchar(100), Adres nvarchar(100),Phone nvarchar(100),Admin int)";

            //    SqlCommand sqlCommand = new SqlCommand(TwoCommand, sqlConnection);
            //    SqlDataReader dataReader = sqlCommand.ExecuteReader();

            //    sqlConnection.Close();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog = UserBase;Integrated Security=True"))
            {
                sqlConnection.Open();

                string TwoCommand = $"INSERT INTO Users VALUES ({Id.Text},'{Login.Text}','{Password.Text}','{Adres.Text}','{Phone.Text}',";

                TwoCommand += Admin.Checked ? "1" : "0";

                TwoCommand += ")";

                SqlCommand sqlCommand = new SqlCommand(TwoCommand, sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                sqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "userBaseDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.userBaseDataSet.Users);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.userBaseDataSet.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog = UserBase;Integrated Security=True"))
            {
                sqlConnection.Open();

                string TwoCommand = "delete from Users where Users.Id = " + IdDelete.Text;

                SqlCommand sqlCommand = new SqlCommand(TwoCommand, sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                sqlConnection.Close();
            }
        }
    }
}
