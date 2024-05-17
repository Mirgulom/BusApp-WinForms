using System.Data;
using Microsoft.Data.Sqlite;

namespace FCKNDB
{
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
            SqliteCommand selectcommand = new SqliteCommand("SELECT * FROM Города", Connection.Connect());
            SqliteDataReader reader = selectcommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            VIVdgvw.DataSource = table;

            SqliteCommand command = new SqliteCommand("Select Код_города from Города", Connection.Connect());
            citycodetbx.Text = Convert.ToString(command.ExecuteScalar()); ;
            int entrynum = 1;

            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            selectCommand.CommandText = $"Select Код_города from Города where Код_города = {entrynum}";
            citycodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Город from Города where Код_города = {entrynum}";
            citytbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            /*selectCommand.CommandText = $"Select Код_кассеты from Города where №_акта_выдачи = {entrynum}";
            KassCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Количество_дней from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            numofdaystbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Дата_выдачи from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            dataVtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Залог from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            zalogtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Цена from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            pricetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Возврат from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            vozvrattbx.Text = Convert.ToString(selectCommand.ExecuteScalar());*/
            PrevEntrybtn.Enabled = false;
            command.CommandText = "SELECT Count (*) FROM Города";
            countentrieslabel.Text = Convert.ToString(command.ExecuteScalar());
        }

        private void VIVForm_Load(object sender, EventArgs e)
        {

            
        }

        private void PrevEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(citycodetbx.Text);
            entrynum--;
            SqliteCommand selectCommand = Connection.Connect().CreateCommand();
            selectCommand.CommandText = "Select Код_города from Города";
            if (entrynum == 1)
                PrevEntrybtn.Enabled = false;
            try
            {
                citycodetbx.Text = $"{entrynum}";
                selectCommand.CommandText = $"Select Город from Города where Код_города = {entrynum}";
                citytbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Город from Города where Код_города = {entrynum}"; 
                /*KassCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Количество_дней from Выдача_и_возврат where №_акта_выдачи = {entrynum}"; 
                numofdaystbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Дата_выдачи from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
                dataVtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Залог from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
                zalogtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Цена from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
                pricetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Возврат from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
                vozvrattbx.Text = Convert.ToString(selectCommand.ExecuteScalar());*/
            }
            catch (NullReferenceException)
            {
                citycodetbx.Text = $"{entrynum}";
                citytbx.Text = "";
                /*KassCodetbx.Text = "";
                numofdaystbx.Text = "";
                dataVtbx.Text = "";
                zalogtbx.Text = "";
                pricetbx.Text = "";
                vozvrattbx.Text = "";*/
            }
        }

        private void NextEntrybtn_Click(object sender, EventArgs e)
        {
            PrevEntrybtn.Enabled = true;
            int entrynum = int.Parse(citycodetbx.Text);

                entrynum++;
                SqliteCommand selectCommand = Connection.Connect().CreateCommand();
                citycodetbx.Text = $"{entrynum}";
                selectCommand.CommandText = $"Select Город from Города where Код_города = {entrynum}";
                citytbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
                selectCommand.CommandText = $"Select Код_кассеты from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            /*KassCodetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Количество_дней from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            numofdaystbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Дата_выдачи from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            dataVtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Залог from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            zalogtbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Цена from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            pricetbx.Text = Convert.ToString(selectCommand.ExecuteScalar());
            selectCommand.CommandText = $"Select Возврат from Выдача_и_возврат where №_акта_выдачи = {entrynum}";
            vozvrattbx.Text = Convert.ToString(selectCommand.ExecuteScalar());*/
            /* {KassCodetbx.Text}, {numofdaystbx.Text}, {dataVtbx.Text}, {zalogtbx.Text}, {pricetbx.Text}, {vozvrattbx.Text}*/
        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            SqliteCommand insertCommand = Connection.Connect().CreateCommand();
            insertCommand.CommandText = 
                $"Insert into Города values({citycodetbx.Text}, '{citytbx.Text}')";
            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (SqliteException) 
            {
                MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqliteCommand selectcommand = new SqliteCommand("SELECT * FROM Города", Connection.Connect());
            SqliteDataReader reader = selectcommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            VIVdgvw.DataSource = table;
            selectcommand.CommandText = "SELECT Count (*) FROM Города";
            countentrieslabel.Text = Convert.ToString(selectcommand.ExecuteScalar());
        }

        private void UpdEntrybtn_Click(object sender, EventArgs e)
        {

            int entrynum = int.Parse(citycodetbx.Text);
            SqliteCommand updateCommand = Connection.Connect().CreateCommand();
            updateCommand.CommandText = $"UPDATE Города SET Город = '{citytbx.Text}' WHERE Код_города = {entrynum}";
            updateCommand.ExecuteNonQuery();

            SqliteCommand command = new SqliteCommand("SELECT * FROM Города", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            VIVdgvw.DataSource = table;
            updateCommand.CommandText = "SELECT Count (*) FROM Города";
            countentrieslabel.Text = Convert.ToString(updateCommand.ExecuteScalar());
        }

        private void DeleteEntrybtn_Click(object sender, EventArgs e)
        {
            int entrynum = int.Parse(citycodetbx.Text);
            SqliteCommand deleteCommand = Connection.Connect().CreateCommand();
            deleteCommand.CommandText = $"Delete from Города where Код_города = {entrynum}";
            DialogResult result = MessageBox.Show($"Запись №{entrynum} будет удалена безвозвратно. \nВы уверены?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                citycodetbx.Text = $"{entrynum}";
                citytbx.Text = "";
                /*KassCodetbx.Text = "";
                numofdaystbx.Text = "";
                dataVtbx.Text = "";
                zalogtbx.Text = "";
                pricetbx.Text = "";
                vozvrattbx.Text = "";*/
            }
            SqliteCommand command = new SqliteCommand("SELECT * FROM Города", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            VIVdgvw.DataSource = table;
            deleteCommand.CommandText = "SELECT Count (*) FROM Города";
            countentrieslabel.Text = Convert.ToString(deleteCommand.ExecuteScalar());
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
                    }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Tablegbx_Enter(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
/* Код_кассеты = {KassCodetbx.Text}, Количество_дней = {numofdaystbx.Text}, Дата_выдачи = {dataVtbx.Text}, Залог = {zalogtbx.Text}, Цена = {pricetbx.Text},Возврат = {vozvrattbx.Text}*/