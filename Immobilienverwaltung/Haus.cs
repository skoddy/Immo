using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immobilienverwaltung
{
    public class Haus : IPopulateData
    {
        public int Id { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Beschreibung { get; set; }
        public int Liegenschaft_id { get; set; }

        public Haus () { }

        public Haus(
            int id,
            string strasse, 
            string hausnummer, 
            string plz, 
            string ort,
            string beschreibung, 
            int liegenschaft_id)
        {
            Id = id;
            Strasse = strasse;
            Hausnummer = hausnummer;
            PLZ = plz;
            Ort = ort;
            Beschreibung = beschreibung;
            Liegenschaft_id = liegenschaft_id;
        }

        public List<Haus> GetList(IDatabase db)
        {
            return db.Read<Haus>("haus");
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Strasse = dataReader.GetString(1);
            Hausnummer = dataReader.GetString(2);
            PLZ = dataReader.GetString(3);
            Ort = dataReader.GetString(4);
            Beschreibung = dataReader.GetString(5);
            Liegenschaft_id = dataReader.GetInt32(6);
        }
    }
}
