using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<Producto> productos = new List<Producto>();
        int contadorCodigo = 1;
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Modificar producto");
            Console.WriteLine("4. Consultar producto");
            Console.WriteLine("5. Mostrar todos los productos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarProducto(productos, ref contadorCodigo);
                    break;
                case 2:
                    EliminarProducto(productos);
                    break;
                case 3:
                    ModificarProducto(productos);
                    break;
                case 4:
                    ConsultarProducto(productos);
                    break;
                case 5:
                    MostrarProductos(productos);
                    break;
                case 6:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void AgregarProducto(List<Producto> productos, ref int contadorCodigo)
    {
        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Cantidad del producto: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        productos.Add(new Producto(contadorCodigo, nombre, cantidad, precio));
        Console.WriteLine("Producto agregado.\n");
        contadorCodigo++;
    }

    static void ConsultarProducto(List<Producto> productos)
    {
        Console.Write("Código del producto a consultar: ");
        int codigo = int.Parse(Console.ReadLine());

        Producto producto = productos.Find(p => p.Codigo == codigo);

        if (producto != null)
        {
            Console.WriteLine(producto);
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    static void MostrarProductos(List<Producto> productos)
    {
        Console.WriteLine("\nInventario:");
        foreach (Producto producto in productos)
        {
            Console.WriteLine(producto);
        }
    }

    static void ModificarProducto(List<Producto> productos)
    {
        Console.Write("Código del producto a modificar: ");
        int codigo = int.Parse(Console.ReadLine());

        Producto producto = productos.Find(p => p.Codigo == codigo);

        if (producto != null)
        {
            Console.Write("Nuevo nombre del producto: ");
            producto.Nombre = Console.ReadLine();

            Console.Write("Nueva cantidad del producto: ");
            producto.Cantidad = int.Parse(Console.ReadLine());

            Console.Write("Nuevo precio del producto: ");
            producto.Precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Producto modificado.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    static void EliminarProducto(List<Producto> productos)
    {
        Console.Write("Código del producto a eliminar: ");
        int codigo = int.Parse(Console.ReadLine());

        Producto producto = productos.Find(p => p.Codigo == codigo);

        if (producto != null)
        {
            productos.Remove(producto);
            Console.WriteLine("Producto eliminado.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }
}

class Producto
{
    public int Codigo;
    public string Nombre;
    public int Cantidad;
    public double Precio;

    public Producto(int codigo, string nombre, int cantidad, double precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        Cantidad = cantidad;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"Código: {Codigo}, Nombre: {Nombre}, Cantidad: {Cantidad}, Precio: {Precio}";
    }
}
