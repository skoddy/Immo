using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immobilienverwaltung
{
    public partial class Main : Form
    {
        IDatabase db = new MySQLDatabase(new DBConfig());

        public Main()
        {
            InitializeComponent();
        }

        private void tabVerwalter_Enter(object sender, EventArgs e)
        {
            ListView lvVerwalter = createListView();

            lvVerwalter.Columns.Add("Id", -2, HorizontalAlignment.Left);
            lvVerwalter.Columns.Add("Vorname", -2, HorizontalAlignment.Left);
            lvVerwalter.Columns.Add("Nachname", -2, HorizontalAlignment.Left);

            Verwalter vw = new Verwalter();

            List<Verwalter> listVerwalter = vw.GetList(db);

            foreach (Verwalter verwalter in listVerwalter)
            {
                ListViewItem item = new ListViewItem(verwalter.Id.ToString());
                item.SubItems.Add(verwalter.Vorname);
                item.SubItems.Add(verwalter.Nachname);
                lvVerwalter.Items.Add(item);
            }

            tabVerwalter.Controls.Add(lvVerwalter);
        }

        private void tabLiegenschaft_Enter(object sender, EventArgs e)
        {
            ListView lvLiegenschaft = createListView();

            lvLiegenschaft.Columns.Add("Id", -2, HorizontalAlignment.Left);
            lvLiegenschaft.Columns.Add("Name", -2, HorizontalAlignment.Left);
            lvLiegenschaft.Columns.Add("Verwalter", -2, HorizontalAlignment.Left);

            Liegenschaften ls = new Liegenschaften();

            List<Liegenschaften> listLiegenschaften = ls.GetList(db);

            foreach (Liegenschaften liegenschaft in listLiegenschaften)
            {
                ListViewItem item = new ListViewItem(liegenschaft.Id.ToString());
                item.SubItems.Add(liegenschaft.Name);
                item.SubItems.Add(liegenschaft.Verwalter_id.ToString());
                lvLiegenschaft.Items.Add(item);
            }

            tabLiegenschaft.Controls.Add(lvLiegenschaft);
        }

        private void tabHaus_Enter(object sender, EventArgs e)
        {
            ListView lvHaus = createListView();

            lvHaus.Columns.Add("Id", -2, HorizontalAlignment.Left);
            lvHaus.Columns.Add("Strasse", -2, HorizontalAlignment.Left);
            lvHaus.Columns.Add("Hausnummer", -2, HorizontalAlignment.Left);
            lvHaus.Columns.Add("PLZ", -2, HorizontalAlignment.Left);
            lvHaus.Columns.Add("Ort", -2, HorizontalAlignment.Left);
            lvHaus.Columns.Add("Beschreibung", -2, HorizontalAlignment.Left);
            lvHaus.Columns.Add("Liegenschaft", -2, HorizontalAlignment.Left);

            Haus h = new Haus();

            List<Haus> listHaus = h.GetList(db);

            foreach (Haus haus in listHaus)
            {
                ListViewItem item = new ListViewItem(haus.Id.ToString());
                item.SubItems.Add(haus.Strasse);
                item.SubItems.Add(haus.Hausnummer);
                item.SubItems.Add(haus.PLZ);
                item.SubItems.Add(haus.Ort);
                item.SubItems.Add(haus.Beschreibung);
                item.SubItems.Add(haus.Liegenschaft_id.ToString());
                lvHaus.Items.Add(item);
            }

            tabHaus.Controls.Add(lvHaus);
        }

        private void tabWohung_Enter(object sender, EventArgs e)
        {

        }

        private void tabMieter_Enter(object sender, EventArgs e)
        {

        }

        private ListView createListView()
        {
            ListView lv = new ListView();

            lv.Dock = DockStyle.Fill;
            lv.View = View.Details;
            lv.LabelEdit = true;
            lv.AllowColumnReorder = true;
            lv.FullRowSelect = true;
            lv.GridLines = false;
            lv.Sorting = SortOrder.Ascending;

            return lv;
        }
    }
}
