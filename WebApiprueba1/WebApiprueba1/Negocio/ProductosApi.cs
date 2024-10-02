namespace Negocio
{
    public class ProductosApi
    {
        static List<Producto> products = new List<Producto>();
        public List<Producto> GetAll () {

            return Datos.List.OrderBy(item => item.Id).ToList();
        }

        public Producto GetById (int id)
        {
            var producto = Datos.List.FirstOrDefault(item => item.Id == id);

            return producto;

        }

        public Producto Post(Producto producto)
        {
            producto.Id = Datos.List.Count + 1;
            Datos.List.Add(producto);
            return producto;
        }

        public Producto Put(Producto prod)
        {
            var product = Datos.List.FirstOrDefault(item => item.Id == prod.Id);
            if (product == null)
            {
                return new Producto(-1, "","");
            }
            Datos.List.Remove(product);
            Datos.List.Add(prod);
            return prod;
        }


    }
}