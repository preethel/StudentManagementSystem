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


namespace StudentManagementSystem
{
    public partial class RegistrationForm : Form
    {
        private string name;
        private string age;
        private string address;
        private string mobile;
        private string email;
        private string password;
        private string rePassword;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=StudentManagementSystemDB;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            name = nameTB.Text;
            age = ageTB.Text;
            address = addressTV.Text;
            mobile = mobTB.Text;
            email = mobTB.Text;
            password = passTB.Text;
            rePassword = repassTB.Text;
            string query = "INSERT INTO reg_table(name,age,address,mobile,email,password,rePassword)VALUES(@name,@age,@address,@mobile,@email,@password,@rePassword)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@age", age);
                sqlCommand.Parameters.AddWithValue("@address", address);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@mobile", mobile);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@rePassword", rePassword);
                conn.Open();
                int row = sqlCommand.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Save");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
            

        }
    }
}
