namespace FCKNDB
{
    public partial class ActionsWithDb : Form
    {
        public ActionsWithDb()
        {
            InitializeComponent();
        }

        private void ActionsWithDB_Load(object sender, EventArgs e)
        {

        }

        private void VydIVozvbtn_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm();
            cityForm.Show();
        }

        private void Genrebtn_Click(object sender, EventArgs e)
        {
            RouteForm routeForm = new RouteForm();
            routeForm.Show();
        }

        private void Kassetabtn_Click(object sender, EventArgs e)
        {
            TicketForm sheduleForm = new TicketForm();
            sheduleForm.Show();
        }

        private void Clientbtn_Click(object sender, EventArgs e)
        {
            PassengerForm passengerForm = new PassengerForm();
            passengerForm.Show();
        }

        private void Moviebtn_Click(object sender, EventArgs e)
        {
            sheduleForm ticketForm = new sheduleForm();
            ticketForm.Show();
        }

        private void searchformbtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.Show();

        }
    }
}
