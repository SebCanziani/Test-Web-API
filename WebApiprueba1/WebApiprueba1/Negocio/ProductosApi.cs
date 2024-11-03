using Dapper;
using MySql.Data.MySqlClient;
using Negocio.Modelos;
using System.ComponentModel;


namespace Negocio
{
    public class ProductosApi
    {

        private const string connStr = "Server=sql10.freemysqlhosting.net;Database=sql10741376;Uid=sql10741376;Pwd=vqRiz5UenI;";

         List<Producto> productos = new List<Producto>();

        public List<Producto> GetAll () {

            using (MySqlConnection myConn = new MySqlConnection(connStr))
            {
                myConn.Open();

                string sql = "SELECT * FROM Products";

                productos = myConn.Query<Producto>(sql).ToList();
            }
            return productos;
        }

        public List<string> GetAllCategorias()
        {
            List<string> listaprod = new List<string>();

            using (MySqlConnection myConn = new MySqlConnection(connStr))
            {
                myConn.Open();

                string sql = "SELECT Category FROM Categories";

                listaprod = myConn.Query<string>(sql).ToList();
            }
            return listaprod;
        }


        /*


        public Producto GetById (int id)
        {
            var producto = Datos.prodlist.FirstOrDefault(item => item.Id == id);

            return producto;

        }

        public Producto Post(Producto producto)
        {
            producto.Id = Datos.prodlist.Count + 1;
            Datos.prodlist.Add(producto);
            return producto;
        }

        public Producto Put(Producto prod)
        {
            var product = Datos.prodlist.FirstOrDefault(item => item.Id == prod.Id);
            if (product == null)
            {
                return new Producto(-1, "","");
            }
            Datos.prodlist.Remove(product);
            Datos.prodlist.Add(prod);
            return prod;
        }


        public int Delete(int id)
        {
            return Datos.prodlist.RemoveAll(item => item.Id == id);
        }

         */


    }
}