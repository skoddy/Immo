using System.Collections.Generic;
using System.Data.Common;

namespace Immobilienverwaltung
{
    public interface IPopulateData
    {
        void PopulateData(DbDataReader dataReader);
    }
}
