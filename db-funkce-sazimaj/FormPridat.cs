using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace db_funkce_sazimaj
{
    public partial class FormPridat: Form
    {
        public FormPridat()
        {
            InitializeComponent();
        }
        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection("Data Source=zapujcky.db;Version=3;"))
            {
                con.Open();

                string query = "INSERT INTO zapujcky (jmeno, predmet, datum_zapujcky, vraceno) VALUES (@jmeno, @predmet, @datum, 0)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@jmeno", textBoxJmeno.Text);
                    cmd.Parameters.AddWithValue("@predmet", textBoxPredmet.Text);
                    cmd.Parameters.AddWithValue("@datum", dateTimePickerZapujcka.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Zápůjčka uložena.");
            this.Close();
        }
    }
}
