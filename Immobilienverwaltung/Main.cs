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
        public delegate void ThresholdReachedEventHandler(object sender, EventArgs e);
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
            lvVerwalter.Activation = ItemActivation.TwoClick;
            tabVerwalter.Controls.Add(lvVerwalter);
        }



        private void tabLiegenschaft_Enter(object sender, EventArgs e)
        {
            ListView lvLiegenschaft = createListView();

            lvLiegenschaft.Columns.Add("Id", -2, HorizontalAlignment.Left);
            lvLiegenschaft.Columns.Add("Name", -2, HorizontalAlignment.Left);
            lvLiegenschaft.Columns.Add("Verwalter", -2, HorizontalAlignment.Left);

            Liegenschaft ls = new Liegenschaft();

            List<Liegenschaft> listLiegenschaften = ls.GetList(db);

            foreach (Liegenschaft liegenschaft in listLiegenschaften)
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

        private void tabWohnung_Enter(object sender, EventArgs e)
        {
            ListView lvWohnung = createListView();

            lvWohnung.Columns.Add("Id", -2, HorizontalAlignment.Left);
            lvWohnung.Columns.Add("Balkon", -2, HorizontalAlignment.Left);
            lvWohnung.Columns.Add("Terasse", -2, HorizontalAlignment.Left);
            lvWohnung.Columns.Add("qm2", -2, HorizontalAlignment.Left);
            lvWohnung.Columns.Add("€ / qm2 ", -2, HorizontalAlignment.Left);
            lvWohnung.Columns.Add("Zimmer", -2, HorizontalAlignment.Left);
            lvWohnung.Columns.Add("Haus", -2, HorizontalAlignment.Left);

            Wohnung w = new Wohnung();

            List<Wohnung> listWohnung = w.GetList(db);

            foreach (Wohnung wohnung in listWohnung)
            {
                ListViewItem item = new ListViewItem(wohnung.Id.ToString());
                item.SubItems.Add(wohnung.Balkon.ToString());
                item.SubItems.Add(wohnung.Terasse.ToString());
                item.SubItems.Add(wohnung.Qm.ToString());
                item.SubItems.Add(wohnung.QmPreis.ToString());
                item.SubItems.Add(wohnung.Zimmer.ToString());
                item.SubItems.Add(wohnung.Haus_id.ToString());
                lvWohnung.Items.Add(item);
            }

            tabWohnung.Controls.Add(lvWohnung);
        }

        private void tabMieter_Enter(object sender, EventArgs e)
        {
            ListView lvMieter = createListView();

            lvMieter.Columns.Add("Id", -2, HorizontalAlignment.Left);
            lvMieter.Columns.Add("Vorname", -2, HorizontalAlignment.Left);
            lvMieter.Columns.Add("Nachname", -2, HorizontalAlignment.Left);
            lvMieter.Columns.Add("geb. am", -2, HorizontalAlignment.Left);
            lvMieter.Columns.Add("Wohnung", -2, HorizontalAlignment.Left);

            Mieter m = new Mieter();

            List<Mieter> listMieter = m.GetList(db);

            foreach (Mieter mieter in listMieter)
            {
                ListViewItem item = new ListViewItem(mieter.Id.ToString());
                item.SubItems.Add(mieter.Vorname);
                item.SubItems.Add(mieter.Nachname);
                item.SubItems.Add(mieter.Gebdat.ToString("dd.MM.yyyy"));
                item.SubItems.Add(mieter.Wohnungs_id.ToString());
                lvMieter.Items.Add(item);
            }

            tabMieter.Controls.Add(lvMieter);
        }

        private ListView createListView()
        {
            ListView lv = new ListView();

            lv.Dock = DockStyle.Fill;
            lv.View = View.Details;
            lv.LabelEdit = false;
            lv.AllowColumnReorder = true;
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.Sorting = SortOrder.Ascending;
           
            return lv;
        }

    }
}
