using System.Data;

namespace BackendPlatypus
{
    public class ProveedoresController
    {
        public DataTable Search(string id, string description)
        {
            string query;

            if (id != string.Empty)
            {
                query = $"select * from Stock where code = {id}";
            }
            else
            {
                query = $"select * from Stock where Name like '%{description}%' or Brand like '%{description}%' or Supplier like '%{description}%'"; ;
            }

            return SqlController.NewQuery(query);
        }

        public DataTable Fill()
        {
            return SqlController.NewQuery($"select * from Proveedores");
        }

        public void DeleteItem(string id)
        {
            SqlController.NewQuery($"DELETE FROM Stock WHERE Code = '{id}'");
        }

        public void UpdateItem(string id, string Name, string Brand, string Price, string Stock, string Supplier, string Discount)
        {
            string query = "UPDATE stock " +
                $"SET Name = '{Name}', Brand = '{Brand}', Price = '{Price}', Stock = '{Stock}', Supplier = '{Supplier}', Discount = '{Discount}'" +
                $"WHERE Code = {id};";

            SqlController.NewQuery(query);
        }

        public void InsertItem(string id, string Name, string Brand, string Price, string Stock, string Supplier, string Discount)
        {
            string query = "INSERT INTO stock " +
                $"VALUES ('{id}', '{Name}', '{Brand}', '{Price}', '{Stock}', '{Supplier}', '{Discount}');";

            SqlController.NewQuery(query);
        }
    }
}
