using SQLite.Net.Attributes;

namespace SQLiteEx
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public long EmpId
        { get; set; }
        [NotNull]
        public string EmpName
        { get; set; }
        public string Company
        { get; set; }
        public string Designation
        { get; set; }
        public string Department
        { get; set; }
        public string Qualification
        { get; set; }
    }
}
