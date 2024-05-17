using Microsoft.Data.Sqlite;

namespace FCKNDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            ActionsWithDb acDb = new ActionsWithDb();
            acDb.ShowDialog();

        }
    }
}