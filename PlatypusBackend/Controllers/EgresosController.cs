using System;
using System.Data;

namespace BackendPlatypus.Controllers
{
    public class EgresosController
    {
        public void InsertItem(string id, string ProveedorName, string TotalCash, string ProveedorCode)
        {
            string query = "INSERT INTO Egresos (Id, ProveedorName, totalCash, Code) " +
                $"VALUES ('{id}', '{ProveedorName}', '{TotalCash}', '{ProveedorCode}');";

            SqlController.NewQuery(query);
        }

        public DataTable Fill()
        {
            return SqlController.NewQuery($"select * from Egresos"); //where created_at = {DateTime.Today.ToShortDateString()}
        }
    }
}
