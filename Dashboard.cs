namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people;
        
        public Dashboard()
        {
            InitializeComponent();
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(lastName.Text);
        }
    }
}