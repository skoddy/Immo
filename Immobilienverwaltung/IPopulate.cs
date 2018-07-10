using System.Data.Common;

namespace Immobilienverwaltung
{
    public interface IPopulate
    {
        void PopulateData(DbDataReader dataReader);
    }
}
