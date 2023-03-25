using ConsoleApp4.Models;
using ConsoleApp4.DAO;

CrudProducto1 CrudProducto = new CrudProducto1();
Producto1 Producto = new Producto1();

Console.WriteLine("Menu");
Console.WriteLine("pulse 1 para insertar un nuevo producto");
Console.WriteLine("pulse 0 para cancelar");
var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.WriteLine("ingresa el nombre del producto");
            Producto.Nombre = Console.ReadLine();
            Console.WriteLine("ingrese la descripcion del producto");
            Producto.Descripcion = Console.ReadLine();
            Console.WriteLine("ingrese el precio del producto ");
            Producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad en stock");
            Producto.Stock = Convert.ToInt32(Console.ReadLine());
            CrudProducto.AgregarProducto(Producto);
            Console.WriteLine("El producto se agrego correctamente ");
            Console.WriteLine("pulsa 1 para agregar otro producto");
            Console.WriteLine("pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;
}



#region Listar
//// See https://aka.ms/new-console-template for more information
//using ConsoleApp4.Models;

//Console.WriteLine("Hello, World!");

//AlmacenContext db = new AlmacenContext();

//Console.WriteLine("Ingrese el nombre del producto: ");
//string nombre = Console.ReadLine();
//Console.WriteLine("Ingrese la descripción del producto: ");
//string descripcion = Console.ReadLine();
//Console.WriteLine("Ingrese el precio del producto: ");
//decimal precio = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese el stock del producto: ");
//int stock = int.Parse(Console.ReadLine());


//var producto = new Producto1 { Nombre = nombre, Descripcion = descripcion, Precio = precio, Stock = stock };
//db.Producto1s.Add(producto);
//db.SaveChanges();
#endregion
#region Listar
//var ListProducto1s = db.Producto1s.ToList();
//        foreach (var usu in ListProducto1s){
//            Console.WriteLine(usu.Nombre);
//        }
#endregion
#region Insertar
//Producto1 producto = new Producto1();
//producto.Nombre = "coca";
//producto.Descripcion = "gaseosa";
//producto.Precio = 34;
//producto.Stock = 2;

//db.Producto1s.Add(producto);
//db.SaveChanges();
#endregion