namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=SANG;Initial Catalog=QLSV;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection = conn;
        }
    }
}
