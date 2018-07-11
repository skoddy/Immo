using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immobilienverwaltung
{
    public class Mieter : IPopulateData
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Gebdat { get; set; }
        public int Wohnungs_id { get; set; }

        public Mieter() { }

        public Mieter(
            int id,
            string vorname,
            string nachname,
            DateTime gebdat,
            int wohnungs_id)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Gebdat = gebdat;
            Wohnungs_id = wohnungs_id;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Vorname = dataReader.GetString(1);
            Nachname = dataReader.GetString(2);
            Gebdat = dataReader.GetDateTime(3);
            Wohnungs_id = dataReader.GetInt32(4);
        }
    }
}
