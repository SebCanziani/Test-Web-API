using Dapper;
using MySql.Data.MySqlClient;
using Negocio.Modelos;
using System.ComponentModel;


namespace Negocio
{
    public class ProductosApi
    {

        private const string connStr = "Server=db4free.net;Database=lasnieves110424;Uid=lasnieves110424;Pwd=lasnieves110424;";

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


        

      

      
            public Producto GetById(int _id)
            {

            using (MySqlConnection conn = new MySqlConnection(connStr)) { 

                conn.Open();
                string sql = "SELECT Id,Description,Title,Price FROM Products where id = @id";
                Producto producto = conn.QueryFirst<Producto>(sql, new { id = _id });

                return producto;
            }

             }

        

        public Producto Post(Producto producto)
        {
            //producto.Id = Datos.prodlist.Count + 1;
            //Datos.prodlist.Add(producto);
            //return producto;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
               string sql = "INSERT INTO Products (Description,Title,Category,Price) VALUES(@Description,@Title,@Category,@Price)";
                conn.Execute(sql , producto);
            }
            
            return producto;
        }
       
        public Producto Put(Producto producto)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            { 
                conn.Open();
                string sql = "update Products set description=@description,title=@title,category=@category ,price = @price  where id = @id";
                conn.Execute(sql, producto);



            }
        return producto;


            //var product = Datos.prodlist.FirstOrDefault(item => item.Id == prod.Id);
            //if (product == null)
            //{
            //    return new Producto(-1, "","");
            //}
            //Datos.prodlist.Remove(product);
            //Datos.prodlist.Add(prod);
            //return prod;
        }
        /*

        public int Delete(int id)
        {
            return Datos.prodlist.RemoveAll(item => item.Id == id);
        }

         */


    }
}