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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            sparam1rb.Checked = true;
            textsearchrb.Checked = true;
        }

        private void Resultsgbx_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqliteCommand searchCommand = Connection.Connect().CreateCommand();
            if (textsearchrb.Checked == true)
            {
                searchCommand.CommandText = $"SELECT Пункт_назначения FROM Билеты WHERE Пункт_назначения LIKE '%{searchcmbx.Text}%'";
                SqliteDataReader reader = searchCommand.ExecuteReader();
                DataSet ds = new DataSet();
                while (!reader.IsClosed)
                {
                    ds.Tables.Add().Load(reader);
                }
                searchcmbx.DataSource = ds.Tables[0];
                searchcmbx.DisplayMember = "Пункт_назначения";
            }
            else if (numsearchrb.Checked == true)
            {
                if (sparam1rb.Checked == true)
                {
                    searchCommand.CommandText = $"SELECT * FROM Билеты WHERE Цена >{firstvaluetbx.Text} AND Цена <{secondvaluetbx.Text} AND Пункт_назначения LIKE '%{searchcmbx.Text}%'";
                }
                else if (sparam2rb.Checked == true)
                {
                    searchCommand.CommandText = $"SELECT * FROM Билеты WHERE Цена >{firstvaluetbx.Text} AND Цена <={secondvaluetbx.Text} AND Пункт_назначения LIKE '%{searchcmbx.Text}%'";
                }
                else if (sparam3rb.Checked == true)
                {
                    searchCommand.CommandText = $"SELECT * FROM Билеты WHERE Цена >={firstvaluetbx.Text} AND Пункт_назначения LIKE '%{searchcmbx.Text}%'";
                }
                else if (sparam4rb.Checked == true)
                {
                    searchCommand.CommandText = $"SELECT * FROM Билеты WHERE Цена BETWEEN {firstvaluetbx.Text} AND {secondvaluetbx.Text} AND Пункт_назначения LIKE '%{searchcmbx.Text}%'";
                }
                else if (sparam5rb.Checked == true)
                {
                    searchCommand.CommandText = $"SELECT * FROM Билеты WHERE Цена >={firstvaluetbx.Text} AND Цена <{secondvaluetbx.Text} AND Пункт_назначения LIKE '%{searchcmbx.Text}%'";
                }
                else if (sparam6rb.Checked == true)
                {
                    searchCommand.CommandText = $"SELECT * FROM Билеты WHERE Цена <={firstvaluetbx.Text} AND Пункт_назначения LIKE '%{searchcmbx.Text}%'";
                }
                SqliteDataReader reader = searchCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                resultsdgv.DataSource = dt;
            }
        }
        private void searchcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqliteCommand searchCommand = Connection.Connect().CreateCommand();
            searchCommand.CommandText = $"SELECT * FROM Билеты WHERE Пункт_назначения = '{searchcmbx.Text}'";
            SqliteDataReader reader = searchCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            resultsdgv.DataSource = dt;
        }

        private void searchcmbx_MouseClick(object sender, MouseEventArgs e)
        {
            searchcmbx.Text = "";
        }

        private void textsearchrb_CheckedChanged(object sender, EventArgs e)
        {
            if (textsearchrb.Checked)
            {
                entervalslb.Text = "Заполните поле:";
                sparam1rb.Enabled = false;
                sparam2rb.Enabled = false;
                sparam3rb.Enabled = false;
                sparam4rb.Enabled = false;
                sparam5rb.Enabled = false;
                sparam6rb.Enabled = false;
            }
        }

        private void numsearchrb_CheckedChanged(object sender, EventArgs e)
        {
            if (numsearchrb.Checked)
            {
                entervalslb.Text = "Заполните поля:";
                sparam1rb.Enabled = true;
                sparam2rb.Enabled = true;
                sparam3rb.Enabled = true;
                sparam4rb.Enabled = true;
                sparam5rb.Enabled = true;
                sparam6rb.Enabled = true;
            }
        }

        private void searchcmbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqliteCommand searchCommand = Connection.Connect().CreateCommand();
            searchCommand.CommandText = $"SELECT * FROM Билеты WHERE Пункт_назначения = '{searchcmbx.Text}'";
            SqliteDataReader reader = searchCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            resultsdgv.DataSource = dt;
        }
    }
}
