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
    public partial class RouteForm : Form
    {
        public RouteForm()
        {
            InitializeComponent();
            SqliteCommand command = new SqliteCommand("SELECT * FROM Маршруты", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Genredgvw.DataSource = table;

            SqliteCommand sqliteCommand = new SqliteCommand("Select Код_маршрута From Маршруты", Connection.Connect());
            int entrynum = 1;
            try
            {
                //routecodetbx.Text = Convert.ToString(sqliteCommand.ExecuteScalar());
                entrynum = int.Parse(routecodetbx.Text);
                SqliteCommand selectCommand = Connection.Connect().CreateCommand();
                selectCommand.CommandText = $"Select Код_маршрута from Маршруты where Код_маршрута = {entrynum}";
                routecodetbx.Text = Convert.ToString(sqliteCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Код_города from Маршруты where Код_маршрута = {entrynum}";
                citycodetbx.Text = Convert.ToString(sqliteCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Маршрут from Маршруты where Код_маршрута = {entrynum}";
                routetbx.Text = Convert.ToString(sqliteCommand.ExecuteScalar());
                selectCommand.CommandText = "SELECT Count (*) FROM Маршруты";
                countentrieslabel.Text = Convert.ToString(selectCommand.ExecuteScalar());

            }
            catch (FormatException)
            {
                routecodetbx.Text = Convert.ToString(entrynum);
                citycodetbx.Text = "";
                routetbx.Text = "";
            }

            
            PrevEntrybtn.Enabled = false;
            

        }

        private void GenreForm_Load(object sender, EventArgs e)
        {

        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            SqliteCommand insertCommand = Connection.Connect().CreateCommand();
            insertCommand.CommandText = $"INSERT INTO Маршруты Values({routecodetbx.Text}, {citycodetbx.Text}, '{routetbx.Text}')";
            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (SqliteException)
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqliteCommand command = new SqliteCommand("SELECT * FROM Маршруты", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Genredgvw.DataSource = table;
            insertCommand.CommandText = "SELECT Count (*) FROM Маршруты";
            countentrieslabel.Text = Convert.ToString(insertCommand.ExecuteScalar());
        }

        private void UpdEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(routecodetbx.Text);
            SqliteCommand updateCommand = Connection.Connect().CreateCommand();
            updateCommand.CommandText = $"UPDATE Маршруты SET Код_города = {citycodetbx.Text}, Маршрут = '{routetbx.Text}' WHERE  Код_маршрута = {entrynum}";
            updateCommand.ExecuteNonQuery();

            SqliteCommand command = new SqliteCommand("SELECT * FROM Маршруты", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Genredgvw.DataSource = table;
        }

        private void PrevEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(routecodetbx.Text);
            entrynum--;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            selectCommand.CommandText = $"Select Код_маршрута from Маршруты";
            if (entrynum == 1)
                PrevEntrybtn.Enabled = false;
            try
            {
                routecodetbx.Text = Convert.ToString(entrynum);
                selectCommand.CommandText = $"Select Код_города from Маршруты where Код_маршрута = {entrynum}";
                citycodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
                selectCommand.CommandText = $"Select Маршрут from Маршруты where Код_маршрута = {entrynum}";
                routetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            }
            catch
            {
                citycodetbx.Text = "";
                routetbx.Text = "";
            }
        }

        private void NextEntrybtn_Click(object sender, EventArgs e)
        {
            PrevEntrybtn.Enabled = true;
            int entrynum = int.Parse(routecodetbx.Text);
            entrynum++;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            routecodetbx.Text = Convert.ToString(entrynum);
            selectCommand.CommandText = $"Select Код_города from Маршруты where Код_маршрута = {entrynum}";
            citycodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
            selectCommand.CommandText = $"Select Маршрут from Маршруты where Код_маршрута = {entrynum}";
            routetbx.Text = Convert.ToString(selectCommand.ExecuteScalar()) ?? "";
        }

        private void DeleteEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(routecodetbx.Text);
            SqliteCommand deleteCommand = Connection.Connect().CreateCommand();
            deleteCommand.CommandText = $"Delete from Маршруты where Код_маршрута = {entrynum}";
            DialogResult result = MessageBox.Show("Запись будет удалена безвозвратно. \nВы уверены?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                routecodetbx.Text = Convert.ToString(entrynum);
                citycodetbx.Text = "";
                routetbx.Text = "";
            }
            SqliteCommand command = new SqliteCommand("SELECT * FROM Маршруты", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Genredgvw.DataSource = table;
            deleteCommand.CommandText = "SELECT Count (*) FROM Маршруты";
            countentrieslabel.Text = Convert.ToString(deleteCommand.ExecuteScalar());

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void VydIVozpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Genredgvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
