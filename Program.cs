using BibliotekDB.Data;

namespace BibliotekDB;

internal class Program
{
    static void Main(string[] args)
    {
        DataAccess dataAccess = new DataAccess();
        dataAccess.Seed();
    }
}
