using SQLite;

namespace SQLiteEx
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
