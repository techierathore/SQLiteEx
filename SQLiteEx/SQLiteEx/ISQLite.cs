using SQLite.Net;

namespace SQLiteEx
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
