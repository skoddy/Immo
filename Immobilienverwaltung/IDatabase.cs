using System.Collections.Generic;

namespace Immobilienverwaltung
{
    public interface IDatabase
    {
        void Connect();
        void Disconnect();
        void Create<T>(string table, T obj);
        List<T> Read<T>(string table) where T : IPopulate, new();
        void Update<T>(string table, T obj);
        void Delete();
    }
}
