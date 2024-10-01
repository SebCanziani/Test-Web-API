using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class Datos
    {
        public static List<Producto> List = new List<Producto>()
        {
            new Producto() { Id = 1, Description = "verde", Name = "marcos" }, 
            
            new Producto() { Id = 14, Description = "rosa", Name = "juliana" },

             new Producto() { Id = 33, Description = "azul", Name = "jose" },

        };

    }

}