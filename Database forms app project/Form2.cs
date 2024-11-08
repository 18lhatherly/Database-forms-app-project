using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Database_forms_app_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ComboBox tables = new ComboBox();
            tables.Location = new Point(10, 10);
            tables.DropDownStyle = ComboBoxStyle.DropDownList;
            tables.Name = "tablesList";
            Controls.Add(tables);

            MySqlConnection con = new MySqlConnection("server=192.168.35.248;uid=18LHatherly;pwd=4fJyYyWU;database=18LHatherly _Bookshop");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string SQL = "SHOW TABLES";
            cmd.CommandText = SQL;
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    tables.Items.Add(reader[i].ToString());
                }
                
            }
            con.Close();
        }
    }
}
