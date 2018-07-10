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
    public partial class Form1 : Form
    {
        IDatabase db = new MySQLDatabase(new DBConfig());

        public Form1()
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

            List<Verwalter> listVerwalter = vw.getList(db);

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

            Liegenschaften ls = new Liegenschaften();

            List<Liegenschaften> listLiegenschaften = ls.getList(db);

            foreach (Liegenschaften liegenschaft in listLiegenschaften)
            {
                ListViewItem item = new ListViewItem(liegenschaft.Id.ToString());
                item.SubItems.Add(liegenschaft.Name);
                lvLiegenschaft.Items.Add(item);
            }

            tabLiegenschaft.Controls.Add(lvLiegenschaft);
        }

        private void tabHaus_Enter(object sender, EventArgs e)
        {

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
