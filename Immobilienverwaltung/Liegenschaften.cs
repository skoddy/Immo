using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immobilienverwaltung
{
    public class Liegenschaften : IPopulateData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Verwalter_id { get; set; }

        public Liegenschaften() { }

        public Liegenschaften(int id, string name, int verwalter_id)
        {
            Id = id;
            Name = name;
            Verwalter_id = verwalter_id;
        }

        public List<Liegenschaften> GetList(IDatabase db)
        {
            return db.Read<Liegenschaften>("liegenschaften");
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Name = dataReader.GetString(1);
            Verwalter_id = dataReader.GetInt32(3);
        }
    }
}
