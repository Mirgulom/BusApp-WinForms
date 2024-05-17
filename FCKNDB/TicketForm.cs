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

namespace FCKNDB
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
            SqliteCommand command = new SqliteCommand("SELECT * FROM Билеты", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Kassetadgvw.DataSource = table;

            SqliteCommand sqliteCommand = new SqliteCommand("Select Код_билета From Билеты", Connection.Connect());
            int entrynum = 1;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            ticketCodetbx.Text = $"{entrynum}";
            selectCommand.CommandText = $"Select Код_пассажира From Билеты where Код_билета = {entrynum}";
            passengerCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Код_рейса From Билеты where Код_билета = {entrynum}";
            sheduleCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Цена From Билеты where Код_билета = {entrynum}";
            pricetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Пункт_отправления From Билеты where Код_билета = {entrynum}";
            dataofdeparturetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Пункт_назначения From Билеты where Код_билета = {entrynum}";
            destinationtbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";

            selectCommand.CommandText = "SELECT Count (*) FROM Билеты";
            countentrieslabel.Text = Convert.ToString(selectCommand.ExecuteScalar());

        }

        private void KassetaForm_Load(object sender, EventArgs e)
        {

        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            SqliteCommand insertCommand = Connection.Connect().CreateCommand();
            insertCommand.CommandText = $"INSERT INTO Билеты Values({ticketCodetbx.Text}, {passengerCodetbx.Text}, {sheduleCodetbx.Text}, {pricetbx.Text}, '{dataofdeparturetbx.Text}', '{destinationtbx.Text}')";
            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (SqliteException)
            {
                MessageBox.Show("Заполните поля правильно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqliteCommand command = new SqliteCommand("SELECT * FROM Билеты", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Kassetadgvw.DataSource = table;
            insertCommand.CommandText = "SELECT Count (*) FROM Билеты";
            countentrieslabel.Text = Convert.ToString(insertCommand.ExecuteScalar());
        }

        private void DeleteEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(ticketCodetbx.Text);
            SqliteCommand deleteCommand = Connection.Connect().CreateCommand();
            deleteCommand.CommandText = $"Delete from Билеты where Код_билета = {entrynum}";
            DialogResult result = MessageBox.Show("Запись будет удалена безвозвратно. \nВы уверены?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                ticketCodetbx.Text = Convert.ToString(entrynum);
                passengerCodetbx.Text = "";
                sheduleCodetbx.Text = "";
                pricetbx.Text = "";
                dataofdeparturetbx.Text = "";
                destinationtbx.Text = "";
            }

            SqliteCommand command = new SqliteCommand("SELECT * FROM Билеты", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Kassetadgvw.DataSource = table;
            deleteCommand.CommandText = "SELECT Count (*) FROM Билеты";
            countentrieslabel.Text = Convert.ToString(deleteCommand.ExecuteScalar());

        }

        private void UpdEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(ticketCodetbx.Text);
            SqliteCommand updateCommand = Connection.Connect().CreateCommand();
            updateCommand.CommandText = $"UPDATE Билеты SET Код_пассажира = {passengerCodetbx.Text}, Код_рейса = {sheduleCodetbx.Text}, Цена = '{pricetbx.Text}', Пункт_отправления = '{dataofdeparturetbx.Text}', Пункт_назначения = '{destinationtbx.Text}' WHERE  Код_билета = {entrynum}";
            updateCommand.ExecuteNonQuery();

            SqliteCommand command = new SqliteCommand("SELECT * FROM Билеты", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Kassetadgvw.DataSource = table;
        }

        private void PrevEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(ticketCodetbx.Text);
            entrynum--;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            selectCommand.CommandText = $"Select Код_билета from Билеты";
            if (entrynum == 1)
                PrevEntrybtn.Enabled = false;
            try
            {
                ticketCodetbx.Text = $"{entrynum}";
                selectCommand.CommandText = $"Select Код_пассажира From Билеты where Код_билета = {entrynum}";
                passengerCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
                selectCommand.CommandText = $"Select Код_рейса From Билеты where Код_билета = {entrynum}";
                sheduleCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
                selectCommand.CommandText = $"Select Цена From Билеты where Код_билета = {entrynum}";
                pricetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
                selectCommand.CommandText = $"Select Пункт_отправления From Билеты where Код_билета = {entrynum}";
                dataofdeparturetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
                selectCommand.CommandText = $"Select Пункт_назначения From Билеты where Код_билета = {entrynum}";
                destinationtbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            }
            catch
            {
                //ticketCodetbx.Text = "";
                passengerCodetbx.Text = "";
                sheduleCodetbx.Text = "";
                pricetbx.Text = "";
                dataofdeparturetbx.Text = "";
                destinationtbx.Text = "";
            }
        }

        private void NextEntrybtn_Click(object sender, EventArgs e)
        {
            PrevEntrybtn.Enabled = true;
            int entrynum = int.Parse(ticketCodetbx.Text);
            entrynum++;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            ticketCodetbx.Text = $"{entrynum}";
            selectCommand.CommandText = $"Select Код_пассажира From Билеты where Код_билета = {entrynum}";
            passengerCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Код_рейса From Билеты where Код_билета = {entrynum}";
            sheduleCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Цена From Билеты where Код_билета = {entrynum}";
            pricetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Пункт_отправления From Билеты where Код_билета = {entrynum}";
            dataofdeparturetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Пункт_назначения From Билеты where Код_билета = {entrynum}";
            destinationtbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Kassetadgvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
