using System.Diagnostics;
using System.Data.SqlClient;



namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people;
        
        public Dashboard()
        {
            Debug.WriteLine("Hello");
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string q = $"INSERT INTO Person VALUES ({idInput.Text.ToString()}, '{firstNameInput.Text.ToString()}', " +
                $"'{lastNameInput.Text.ToString()}', '{emailInput.Text.ToString()}', '{phoneInput.Text.ToString()}');";
            string conString = "Data Source=MIN\\SQLEXPRESS;Initial Catalog=SQLDemo;Integrated Security=True";
            
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserting process complete");
                conn.Close();
            }
        }
    }
}