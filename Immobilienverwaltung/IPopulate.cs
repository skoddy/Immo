using System.Data.Common;

namespace Immobilienverwaltung
{
    public interface IPopulate
    {
        void Populate(DbDataReader dataReader);
    }
}
