using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immobilienverwaltung
{
    public class Liegenschaft : IPopulateData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Verwalter_id { get; set; }

        public Liegenschaft() { }

        public Liegenschaft(int id, string name, int verwalter_id)
        {
            Id = id;
            Name = name;
            Verwalter_id = verwalter_id;
        }

        public List<Liegenschaft> GetList(IDatabase db)
        {
            return db.Read<Liegenschaft>("liegenschaft");
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Name = dataReader.GetString(1);
            Verwalter_id = dataReader.GetInt32(2);
        }
    }
}
