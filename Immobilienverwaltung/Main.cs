using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Immobilienverwaltung
{
    public partial class Main : Form
    {
        private DataGridView masterDataGridView = new DataGridView();
        private BindingSource masterBindingSource = new BindingSource();
        private DataGridView detailsDataGridView = new DataGridView();
        private BindingSource detailsBindingSource = new BindingSource();

        public Main()
        {
            masterDataGridView.Dock = DockStyle.Fill;
            detailsDataGridView.Dock = DockStyle.Fill;

            SplitContainer splitContainer1 = new SplitContainer();
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Orientation = Orientation.Vertical;
            splitContainer1.Panel1.Controls.Add(masterDataGridView);
            splitContainer1.Panel2.Controls.Add(detailsDataGridView);

            this.Controls.Add(splitContainer1);
            this.Load += new System.EventHandler(Form1_Load);
            this.Text = "DataGridView master/detail demo";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            masterDataGridView.DataSource = masterBindingSource;
            detailsDataGridView.DataSource = detailsBindingSource;
            GetData();

            masterDataGridView.AutoResizeColumns();
            masterDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            detailsDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            detailsDataGridView.Columns["Liegenschaft_id"].Visible = false;
            detailsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GetData()
        {
            try
            {

                DBConfig conf = new DBConfig();
                MySqlConnection connection = new MySqlConnection(conf.ConnectionString);

                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                MySqlDataAdapter masterDataAdapter = new
                    MySqlDataAdapter("select ls.Id, ls.Name, vw.Nachname as Verwalter from liegenschaft as ls, verwalter as vw " +
                    "where vw.Id = ls.Verwalter_id;", 
                    connection);
                masterDataAdapter.Fill(data, "liegenschaft");

                MySqlDataAdapter detailsDataAdapter = new
                    MySqlDataAdapter("select Id, Strasse, Hausnummer, PLZ, Ort, Beschreibung, Liegenschaft_id from haus", connection);
                detailsDataAdapter.Fill(data, "haus");


                DataRelation relation = new DataRelation("LiegenschaftenHaeuser",
                    data.Tables["liegenschaft"].Columns["Id"],
                    data.Tables["haus"].Columns["Liegenschaft_id"]);
                data.Relations.Add(relation);

                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "liegenschaft";

                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "LiegenschaftenHaeuser";
            }
            catch (MySqlException)
            {
                MessageBox.Show("errrrrrrrrrrrrror lol");
            }
        }
    }
}
