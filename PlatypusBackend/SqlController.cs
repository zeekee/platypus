using ConectionSQL;
using System.Data;

namespace BackendPlatypus
{
    public static class SqlController
    {
        static ConnectionDB connectionDB = new ConnectionDB();

        public static string OpenConnection()
        {
            return connectionDB.Open();
        }

        public static void CloseConnection()
        {
            connectionDB.Close();
        }

        public static DataTable NewQuery(string query)
        {
            return connectionDB.Query(query);
        }
    }
}
