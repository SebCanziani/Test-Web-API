using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelos
{
    public class Producto
    {

        [Range(1, int.MaxValue, ErrorMessage = "El campo Id debe ser un número mayor que cero.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre no puede quedar vacio.")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El Precio no puede ser menor o igual que cero.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "El campo categoria no puede quedar vacio.")]
        public string Category { get; set; }



        public Producto(int id, string title, string description , string category ,decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Category = category;
            Price = price;



        }


    }


}
