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
    public partial class sheduleForm : Form
    {
        public sheduleForm()
        {
            InitializeComponent();
            SqliteCommand command = new SqliteCommand("SELECT Рейсы.Код_рейса, Рейсы.Код_маршрута, Маршруты.Маршрут, Рейсы.№_рейса, Рейсы.Дата_отправления FROM Рейсы, Маршруты Where Рейсы.Код_маршрута = Маршруты.Код_маршрута", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Moviedgvw.DataSource = table;

            SqliteCommand sqliteCommand = new SqliteCommand("Select Код_рейса from Рейсы", Connection.Connect());
            int entrynum = 1;
            try
            {
                shedulecodetbx.Text = Convert.ToString(sqliteCommand.ExecuteScalar());
                entrynum = int.Parse(shedulecodetbx.Text);
                SqliteCommand selectCommand = Connection.Connect().CreateCommand();
                selectCommand.CommandText = $"Select Код_рейса from Рейсы where Код_рейса = {entrynum}";
                shedulecodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Код_маршрута from Рейсы where Код_рейса = {entrynum}";
                routecodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select №_рейса from Рейсы where Код_рейса = {entrynum}";
                numsheduletbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Дата_отправления from Рейсы where Код_рейса = {entrynum}";
                dataofdeparturetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                
            }
            catch (FormatException)
            {
                shedulecodetbx.Text = $"{entrynum}";
                routecodetbx.Text = "";
                numsheduletbx.Text = "";
                dataofdeparturetbx.Text = "";
                
            }
            sqliteCommand.CommandText = "SELECT Count (*) FROM Рейсы";
            countentrieslabel.Text = Convert.ToString(sqliteCommand.ExecuteScalar());
            PrevEntrybtn.Enabled = false;
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        
        private void AddEntry_Click(object sender, EventArgs e)
        {
            SqliteCommand insertCommand = Connection.Connect().CreateCommand();
            insertCommand.CommandText =
                $"INSERT INTO Рейсы VALUES({shedulecodetbx.Text}, {routecodetbx.Text}, {numsheduletbx.Text}, {dataofdeparturetbx.Text})";
            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (SqliteException)
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqliteCommand command = new SqliteCommand("SELECT Рейсы.Код_рейса, Рейсы.Код_маршрута, Маршруты.Маршрут, Рейсы.№_рейса, Рейсы.Дата_отправления FROM Рейсы, Маршруты Where Рейсы.Код_маршрута = Маршруты.Код_маршрута", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Moviedgvw.DataSource = table;

            insertCommand.CommandText = "SELECT Count (*) FROM Рейсы";
            countentrieslabel.Text = Convert.ToString(insertCommand.ExecuteScalar());
        }
         
        private void UpdEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(shedulecodetbx.Text);
            SqliteCommand updateCommand = Connection.Connect().CreateCommand();
            updateCommand.CommandText = $"UPDATE Рейсы SET Код_маршрута = '{routecodetbx.Text}', №_рейса = {numsheduletbx.Text}, Дата_отправления = {dataofdeparturetbx.Text} WHERE  Код_рейса = {entrynum}";
            updateCommand.ExecuteNonQuery();

            SqliteCommand command = new SqliteCommand("SELECT Рейсы.Код_рейса, Рейсы.Код_маршрута, Маршруты.Маршрут, Рейсы.№_рейса, Рейсы.Дата_отправления FROM Рейсы, Маршруты Where Рейсы.Код_маршрута = Маршруты.Код_маршрута", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Moviedgvw.DataSource = table;

        }

        private void PrevEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(shedulecodetbx.Text);
            entrynum--;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            selectCommand.CommandText = $"Select Код_рейса from Рейсы";

            if (entrynum == 1)
                PrevEntrybtn.Enabled = false;
            try
            {
                shedulecodetbx.Text = $"{entrynum}";
                //selectCommand.CommandText = $"Select Код_билета from Билеты where Код_билета = {entrynum}";
                //ticketcodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Код_маршрута from Рейсы where Код_рейса = {entrynum}";
                routecodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select №_рейса from Рейсы where Код_рейса = {entrynum}";
                numsheduletbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Дата_отправления from Рейсы where Код_рейса = {entrynum}";
                dataofdeparturetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                
            }
            catch
            {
                routecodetbx.Text = "";
                numsheduletbx.Text = "";
                dataofdeparturetbx.Text = "";
                shedulecodetbx.Text = "";
            }
        }

        private void NextEntrybtn_Click(object sender, EventArgs e)
        {
            PrevEntrybtn.Enabled = true;
            int entrynum = int.Parse(shedulecodetbx.Text);
            entrynum++;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            shedulecodetbx.Text = $"{entrynum}";
            //selectCommand.CommandText = $"Select Код_билета from Билеты where Код_билета = {entrynum}";
            //ticketcodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Код_маршрута from Рейсы where Код_рейса = {entrynum}";
            routecodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select №_рейса from Рейсы where Код_рейса = {entrynum}";
            numsheduletbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Дата_отправления from Рейсы where Код_рейса = {entrynum}";
            dataofdeparturetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            
        }

        private void DeleteEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(shedulecodetbx.Text);
            SqliteCommand deleteCommand = Connection.Connect().CreateCommand();
            deleteCommand.CommandText = $"Delete from Рейсы where Код_рейса = {entrynum}";
            DialogResult result = MessageBox.Show("Запись будет удалена безвозвратно. \nВы уверены?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                shedulecodetbx.Text = Convert.ToString(entrynum);
                routecodetbx.Text = "";
                numsheduletbx.Text = "";
                dataofdeparturetbx.Text = "";

            }
            SqliteCommand command = new SqliteCommand("SELECT Рейсы.Код_рейса, Рейсы.Код_маршрута, Маршруты.Маршрут, Рейсы.№_рейса, Рейсы.Дата_отправления FROM Рейсы, Маршруты Where Рейсы.Код_маршрута = Маршруты.Код_маршрута", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            Moviedgvw.DataSource = table;

            deleteCommand.CommandText = "SELECT Count (*) FROM Рейсы";
            countentrieslabel.Text = Convert.ToString(deleteCommand.ExecuteScalar());
        }

        private void shedulecodetbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void routecodetbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
