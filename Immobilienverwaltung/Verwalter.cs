using System.Collections.Generic;

namespace Immobilienverwaltung
{
    public class Verwalter
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

    }
}