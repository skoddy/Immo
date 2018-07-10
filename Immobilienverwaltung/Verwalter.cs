using System.Collections.Generic;
using System.Data.Common;

namespace Immobilienverwaltung
{
    public class Verwalter : IPopulateData
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Verwalter() { }

        public Verwalter(int id, string vorname, string nachname)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
        }

        public List<Verwalter> GetList(IDatabase db)
        {
            return db.Read<Verwalter>("verwalter"); 
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Vorname = dataReader.GetString(1);
            Nachname = dataReader.GetString(2);
        }
    }
}