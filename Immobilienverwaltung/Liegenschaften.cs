using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immobilienverwaltung
{
    public class Liegenschaften : IPopulate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Liegenschaften() { }

        public Liegenschaften(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public List<Liegenschaften> getList(IDatabase db)
        {
            List<Liegenschaften> listLiegenschaften = new List<Liegenschaften>();

            listLiegenschaften = db.Read<Liegenschaften>("liegenschaften");

            return listLiegenschaften;
        }

        public void PopulateData(DbDataReader dataReader)
        {
            Id = dataReader.GetInt32(0);
            Name = dataReader.GetString(1);
        }
    }
}
