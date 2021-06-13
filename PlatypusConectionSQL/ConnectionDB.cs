using System;
using System.Data;
using System.Data.SqlClient;

namespace ConectionSQL
{
    public class ConnectionDB
    {
        const string sqlName = "DESKTOP-7MMV0ST\\SQLEXPRESS"; //TODO: Eliminar mi ruta antes de comitear
        const string dbName = "PlatypusDB"; //TODO: Eliminar mi ruta antes de comitear

        string stringConnection = $"Data Source={sqlName};Initial Catalog={dbName}; Integrated Security=True";
        public SqlConnection connectDB = new SqlConnection();

        public ConnectionDB()
        {
            connectDB.ConnectionString = stringConnection;
        }

        public string Open()
        {
            try
            {
                connectDB.Open();
                Console.WriteLine("Conexion abierta");
                return "Ok";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al abrir la base de datos: {e.Message}");
                return "Error";
            }
        }

        public DataTable Query(string query)
        {
            SqlCommand command = new SqlCommand(query, connectDB);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);

            return table;
        }

        public void Close()
        {
            connectDB.Close();
        }
    }
}
