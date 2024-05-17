using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace FCKNDB
{
    public partial class PassengerForm : Form
    {
        public PassengerForm()
        {
            InitializeComponent();
            SqliteCommand selectcommand = new SqliteCommand("SELECT * FROM Пассажиры", Connection.Connect());
            SqliteDataReader reader = selectcommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Clientdgvw.DataSource = table;
            SqliteCommand command = new SqliteCommand("Select Код_пассажира from Пассажиры", Connection.Connect());
            ClientCodetbx.Text = Convert.ToString(command.ExecuteScalar());
            int entrynum = 1;

            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            selectCommand.CommandText = $"Select Код_пассажира from Пассажиры where Код_пассажира = {entrynum}";
            ClientCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select ФИО from Пассажиры where Код_пассажира = {entrynum}";
            FullNametbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Телефон from Пассажиры where Код_пассажира = {entrynum}";
            phonenumbertbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_рейса from Пассажиры where Код_пассажира = {entrynum}";
            numsheduletbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_паспорта from Пассажиры where Код_пассажира = {entrynum}";
            passnumtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_места from Пассажиры where Код_пассажира = {entrynum}";
            numplacetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            PrevEntrybtn.Enabled = false;
            selectCommand.CommandText = "SELECT Count (*) FROM Пассажиры";
            countentrieslabel.Text = Convert.ToString(selectCommand.ExecuteScalar());
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            SqliteCommand insertCommand = Connection.Connect().CreateCommand();
            insertCommand.CommandText =
                $"INSERT INTO Пассажиры VALUES({ClientCodetbx.Text}, '{FullNametbx.Text}', '{phonenumbertbx.Text}', '{numsheduletbx.Text}', {passnumtbx.Text}, {numplacetbx.Text})";
            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (SqliteException)
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqliteCommand selectcommand = new SqliteCommand("SELECT * FROM Пассажиры", Connection.Connect());
            SqliteDataReader reader = selectcommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Clientdgvw.DataSource = table;
            insertCommand.CommandText = "SELECT Count (*) FROM Пассажиры";
            countentrieslabel.Text = Convert.ToString(insertCommand.ExecuteScalar());
        }

        private void UpdEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(ClientCodetbx.Text);
            SqliteCommand updateCommand = Connection.Connect().CreateCommand();
            updateCommand.CommandText = $"UPDATE Пассажиры SET ФИО = '{FullNametbx.Text}', Телефон = '{phonenumbertbx.Text}', №_рейса = {numsheduletbx.Text}, №_паспорта = {passnumtbx.Text}, №_места = {numplacetbx.Text} WHERE  Код_пассажира = {entrynum}";
            updateCommand.ExecuteNonQuery();

            SqliteCommand command = new SqliteCommand("SELECT * FROM Пассажиры", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Clientdgvw.DataSource = table;
        }

        private void Clientdgvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrevEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(ClientCodetbx.Text);
            entrynum--;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            if (entrynum == 1)
                PrevEntrybtn.Enabled = false;
            ClientCodetbx.Text = $"{entrynum}";
            selectCommand.CommandText = $"Select ФИО from Пассажиры where Код_пассажира = {entrynum}";
            FullNametbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Телефон from Пассажиры where Код_пассажира = {entrynum}";
            phonenumbertbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_рейса from Пассажиры where Код_пассажира = {entrynum}";
            numsheduletbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_паспорта from Пассажиры where Код_пассажира = {entrynum}";
            passnumtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_места from Пассажиры where Код_пассажира = {entrynum}";
            numplacetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
        }

        private void NextEntrybtn_Click(object sender, EventArgs e)
        {
            PrevEntrybtn.Enabled = true;
            int entrynum = int.Parse(ClientCodetbx.Text);
            entrynum++;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            if (entrynum == 1)
                PrevEntrybtn.Enabled = false;
            ClientCodetbx.Text = $"{entrynum}";
            selectCommand.CommandText = $"Select ФИО from Пассажиры where Код_пассажира = {entrynum}";
            FullNametbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Телефон from Пассажиры where Код_пассажира = {entrynum}";
            phonenumbertbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_рейса from Пассажиры where Код_пассажира = {entrynum}";
            numsheduletbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_паспорта from Пассажиры where Код_пассажира = {entrynum}";
            passnumtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_места from Пассажиры where Код_пассажира = {entrynum}";
            numplacetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
        }

        private void DeleteEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(ClientCodetbx.Text);
            SqliteCommand deleteCommand = Connection.Connect().CreateCommand();
            deleteCommand.CommandText = $"Delete from Пассажиры where Код_пассажира = {entrynum}";
            DialogResult result = MessageBox.Show("Запись будет удалена безвозвратно. \nВы уверены?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                ClientCodetbx.Text = Convert.ToString(entrynum);
                FullNametbx.Text = "";
                phonenumbertbx.Text = "";
                numsheduletbx.Text = "";
                passnumtbx.Text = "";
                numplacetbx.Text = "";
            }
            SqliteCommand selectcommand = new SqliteCommand("SELECT * FROM Пассажиры", Connection.Connect());
            SqliteDataReader reader = selectcommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Clientdgvw.DataSource = table;
            deleteCommand.CommandText = "SELECT Count (*) FROM Пассажиры";
            countentrieslabel.Text = Convert.ToString(deleteCommand.ExecuteScalar());
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void Tablegbx_Enter(object sender, EventArgs e)
        {

        }

        private void Clientdgvw_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
