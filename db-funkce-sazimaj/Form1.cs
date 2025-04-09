using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace db_funkce_sazimaj
{
    public partial class Form1 : Form
    {
        string cs = "Data Source=zapujcky.db;Version=3;";

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("zapujcky.db"))
            {
                SQLiteConnection.CreateFile("zapujcky.db");
                using (var con = new SQLiteConnection(cs))
                {
                    con.Open();
                    string sql = @"CREATE TABLE zapujcky (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    jmeno TEXT NOT NULL,
                    predmet TEXT NOT NULL,
                    datum_zapujcky TEXT NOT NULL,
                    datum_vraceni TEXT,
                    vraceno INTEGER NOT NULL DEFAULT 0);";
                    using (var cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            NacistZapujcky();
        }

        private void NacistZapujcky()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string query = "SELECT * FROM zapujcky WHERE vraceno = 0 ORDER BY datum_zapujcky DESC";
                using (var cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewZapujcky.DataSource = dt;
                }
            }
        }

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            new FormPridat().ShowDialog();
            NacistZapujcky();
        }

        private void buttonVratit_Click(object sender, EventArgs e)
        {
            if (dataGridViewZapujcky.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewZapujcky.SelectedRows[0].Cells["id"].Value);
                using (var con = new SQLiteConnection(cs))
                {
                    con.Open();
                    string query = "UPDATE zapujcky SET vraceno = 1, datum_vraceni = @dnes WHERE id = @id";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@dnes", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                NacistZapujcky();
            }
        }

        private void buttonObnovit_Click(object sender, EventArgs e)
        {
            NacistZapujcky();
        }

        private void buttonHistorie_Click(object sender, EventArgs e)
        {
            new FormHistorie().ShowDialog();
        }
    }
}
