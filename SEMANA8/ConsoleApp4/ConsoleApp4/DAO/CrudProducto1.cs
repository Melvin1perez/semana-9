using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.DAO
{
    public class CrudProducto1
    {
        public void AgregarProducto(Producto1 ParametroProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                Producto1 producto = new Producto1();
                producto.Nombre = ParametroProducto.Nombre;
                producto.Descripcion = ParametroProducto.Descripcion;
                producto.Precio = ParametroProducto.Precio;
                producto.Stock = ParametroProducto.Stock;
                db.Add(producto);
                db.SaveChanges();

            }
        }


    }
}
