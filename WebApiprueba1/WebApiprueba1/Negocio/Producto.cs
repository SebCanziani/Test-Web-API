using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
    {

        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

       
        public Producto(int id, string Nombre, string Descripcion)
        {
            Id = id;
            Name = Nombre;
            Description = Descripcion;
        }


    }
}
