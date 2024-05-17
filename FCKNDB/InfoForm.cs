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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            SqliteCommand command = new SqliteCommand("SELECT Билеты.Код_билета, Пассажиры.ФИО, Рейсы.№_рейса, Маршруты.Маршрут, Билеты.Пункт_отправления, Билеты.Пункт_назначения, Города.Код_города, Билеты.Цена, Пассажиры.№_места From Города, Маршруты, Рейсы, Билеты, Пассажиры WHERE Билеты.Код_пассажира = Пассажиры.Код_пассажира AND Билеты.Код_рейса = Рейсы.Код_рейса AND Рейсы.Код_маршрута = Маршруты.Код_маршрута AND Маршруты.Код_города = Города.Код_города AND Пассажиры.№_рейса = Рейсы.№_рейса", Connection.Connect());
            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            resultsdgv.DataSource = table;

        }

        private void resultsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
