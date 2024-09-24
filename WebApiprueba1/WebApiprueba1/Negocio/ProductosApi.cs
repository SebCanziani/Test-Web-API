namespace Negocio
{
    public class ProductosApi
    {
        static List<Producto> products = new List<Producto>();
        public List<Producto> GetAll () {

            Producto producto1 = new Producto();
            producto1.Id = 1;
            producto1.Name = "Carlos";
            producto1.Description = "Limpieza";

            Producto producto2 = new Producto();
            producto2.Id = 2;
            producto2.Name = "Jose";
            producto2.Description = "Recepcion";

            Producto producto3 = new Producto();
            producto3.Id = 3;
            producto3.Name = "Lucas";
            producto3.Description = "Gestion";

            products.Add(producto1);
            products.Add(producto2);
            products.Add(producto3);

            return products;

        }
        
      

    }
}