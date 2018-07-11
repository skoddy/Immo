using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immobilienverwaltung
{
    public class Wohnung : IPopulateData
    {
        public int Id { get; set; }
        public bool Balkon { get; set; }
        public bool Terasse { get; set; }
        public double Qm { get; set; }
        public double QmPreis { get; set; }
        public double Zimmer { get; set; }
        public int Haus_id { get; set; }


        public Wohnung() { }

        public Wohnung(
            int id,
            bool balkon,
            bool terasse,
            double qm,
            double qmPreis,
            double zimmer,
            int haus_id
            )
        {
            Id = id;
            Balkon = balkon;
            Terasse = terasse;
            Qm = qm;
            QmPreis = qmPreis;
            Zimmer = zimmer;
            Haus_id = haus_id;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Balkon = dataReader.GetBoolean(1);
            Terasse = dataReader.GetBoolean(2);
            Qm = dataReader.GetDouble(3);
            QmPreis = dataReader.GetDouble(4);
            Zimmer = dataReader.GetDouble(5);
            Haus_id = dataReader.GetInt32(6);
        }
    }
}
