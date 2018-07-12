using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Immobilienverwaltung
{
    public partial class Main : Form
    {
        private DataGridView dgvLiegenschaft = new DataGridView();
        private DataGridView dgvHaus = new DataGridView();

        private BindingSource bsLiegenschaft = new BindingSource();
        private BindingSource bsHaus = new BindingSource();

        public Main()
        {
            dgvLiegenschaft.Dock = DockStyle.Fill;
            dgvHaus.Dock = DockStyle.Fill;

            SplitContainer splitContainer = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical
            };
            splitContainer.Panel1.Controls.Add(dgvLiegenschaft);
            splitContainer.Panel2.Controls.Add(dgvHaus);

            Controls.Add(splitContainer);
            Load += new EventHandler(Form1_Load);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgvLiegenschaft.DataSource = bsLiegenschaft;
            dgvHaus.DataSource = bsHaus;

            GetData();
            
            dgvLiegenschaft.AutoResizeColumns();
            dgvLiegenschaft.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHaus.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            //dgvHaus.Columns["Liegenschaft_id"].Visible = false;
            dgvHaus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GetData()
        {
            try
            {

                DBConfig conf = new DBConfig();
                MySqlConnection connection = new MySqlConnection(conf.ConnectionString);

                DataSet data = new DataSet
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };

                MySqlDataAdapter daLiegenschaft = new MySqlDataAdapter(
"select  l.Id as Id, l.Name, v.Nachname as Verwalter, "+
"count(DISTINCT h.Id) as Anzahl, "+
"count(DISTINCT w.Id) as Anzahl, "+
"count(DISTINCT m.Id) as Mieter "+
"from liegenschaft l "+
"left join verwalter v on l.Verwalter_id = v.Id "+
"left join haus h on l.id = h.Liegenschaft_id "+
"left join wohnung w on w.Haus_id = h.Id "+
"left join mieter m on m.Wohnungs_id = m.Id "+
"group by l.Id", connection);
                daLiegenschaft.Fill(data, "liegenschaft");

                MySqlDataAdapter daHaus = new
                    MySqlDataAdapter("select Id, Strasse, Hausnummer, PLZ, Ort, Beschreibung, Liegenschaft_id from haus", connection);
                daHaus.Fill(data, "haus");


                DataRelation relation = new DataRelation("LiegenschaftenHaeuser",
                    data.Tables["liegenschaft"].Columns["Id"],
                    data.Tables["haus"].Columns["Liegenschaft_id"]);

                data.Relations.Add(relation);

                bsLiegenschaft.DataSource = data;
                bsLiegenschaft.DataMember = "liegenschaft";

                bsHaus.DataSource = bsLiegenschaft;
                bsHaus.DataMember = "LiegenschaftenHaeuser";
            }
            catch (MySqlException)
            {
                MessageBox.Show("errrrrrrrrrrrrror lol");
            }
        }
    }
}
