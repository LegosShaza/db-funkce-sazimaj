using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace db_funkce_sazimaj
{
    public partial class FormHistorie : Form
    {
        string cs = "Data Source=zapujcky.db;Version=3;";

        public FormHistorie()
        {
            InitializeComponent();
            NacistHistorii();
        }

        private void NacistHistorii()
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                string query = "SELECT * FROM zapujcky WHERE vraceno = 1 ORDER BY datum_vraceni DESC";
                using (var cmd = new SQLiteCommand(query, con))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewHistorie.DataSource = dt;

                    if (dataGridViewHistorie.Columns.Contains("vraceno"))
                        dataGridViewHistorie.Columns["vraceno"].Visible = false;
                }
            }
        }
    }
}
