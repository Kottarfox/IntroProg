namespace FinalProg;
class Program
{
    static void Main(string[] args)
    {
        using System;
        using System.Collections.Generic;

namespace Supermercado
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static List<Articulo> articulos = new List<Articulo>();
        static List<Venta> ventas = new List<Venta>();

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Menú Principal:");
                Console.Wr<iteLine("1. Gestión de usuarios");
                Console.WriteLine("2. Gestión de artículos");
                Console.WriteLine("3. Gestión de ventas");
                Console.WriteLine("4. Salir del programa");

                int opcion = LeerEntero("Ingrese la opción deseada: ");

                switch (opcion)
                {
                    case 1:
                        GestionUsuarios();
                        break;
                    case 2:
                        GestionArticulos();
                        break;
                    case 3:
                        GestionVentas();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void GestionUsuarios()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Gestión de usuarios:");
                Console.WriteLine("1. Ver lista de usuarios");
                Console.WriteLine("2. Nuevo usuario");
                Console.WriteLine("3. Editar información de usuario (buscar por c.c)");
                Console.WriteLine("4. Salir de Gestión de usuarios (Menú principal)");

                int opcion = LeerEntero("Ingrese la opción deseada: ");

                switch (opcion)
                {
                    case 1:
                        MostrarUsuarios();
                        break;
                    case 2:
                        CrearUsuario();
                        break;
                    case 3:
                        EditarUsuario();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void GestionArticulos()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Gestión de artículos:");
                Console.WriteLine("1. Ver lista de artículos");
                Console.WriteLine("2. Nuevo artículo");
                Console.WriteLine("3. Editar información del artículo (buscar por id)");
                Console.WriteLine("4. Salir de Gestión de Artículos (Menú principal)");

                int opcion = LeerEntero("Ingrese la opción deseada: ");

                switch (opcion)
                {
                    case 1:
                        MostrarArticulos();
                        break;
                    case 2:
                        CrearArticulo();
                        break;
                    case 3:
                        EditarArticulo();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void GestionVentas()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Gestión de ventas:");
                Console.WriteLine("1. Registrar venta");
                Console.WriteLine("2. Salir de Gestión de venta (Menú principal)");

                int opcion = LeerEntero("Ingrese la opción deseada: ");

                switch (opcion)
                {
                    case 1:
                        RegistrarVenta();
                        break;
                    case 2:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
            Console.WriteLine();
        }
    }

    static void MostrarUsuarios()
    {
        Console.WriteLine("Lista de usuarios:");

        if (usuarios.Count > 0)
        {
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario);
            }
        }
        else
        {
            Console.WriteLine("No hay usuarios registrados.");
        }
    }

    static void CrearUsuario()
    {
        Console.WriteLine("Ingrese los datos del nuevo usuario:");

        string nombre = LeerCadena("Nombre: ");
        string cedula = LeerCadena("Cédula: ");
        string direccion = LeerCadena("Dirección: ");

        Usuario nuevoUsuario = new Usuario(nombre, cedula, direccion);
        usuarios.Add(nuevoUsuario);

        Console.WriteLine("Usuario creado exitosamente.");
    }

    static void EditarUsuario()
    {
        string cedula = LeerCadena("Ingrese la cédula del usuario a editar: ");

        Usuario usuario = usuarios.Find(u => u.Cedula == cedula);

        if (usuario != null)
        {
            Console.WriteLine("Usuario encontrado:");
            Console.WriteLine(usuario);

            Console.WriteLine("Ingrese los nuevos datos del usuario:");

            string nuevoNombre = LeerCadena("Nuevo nombre: ");
            string nuevaDireccion = LeerCadena("Nueva dirección: ");

            usuario.Nombre = nuevoNombre;
            usuario.Direccion = nuevaDireccion;

            Console.WriteLine("Usuario editado exitosamente.");
        }
        else
        {
            Console.WriteLine("No se encontró ningún usuario con la cédula especificada.");
        }
    }

    static void MostrarArticulos()
    {
        Console.WriteLine("Lista de artículos:");

        if (articulos.Count > 0)
        {
            foreach (var articulo in articulos)
            {
                Console.WriteLine(articulo);
            }
        }
        else
        {
            Console.WriteLine("No hay artículos registrados.");
        }
    }

    static void CrearArticulo()
    {
        Console.WriteLine("Ingrese los datos del nuevo artículo:");

        int id = LeerEntero("ID: ");
        string nombre = LeerCadena("Nombre: ");
        double precio = LeerDouble("Precio: ");

        Articulo nuevoArticulo = new Articulo(id, nombre, precio);
        articulos.Add(nuevoArticulo);

        Console.WriteLine("Artículo creado exitosamente.");
    }

    static void EditarArticulo()
    {
        int id = LeerEntero("Ingrese el ID del artículo a editar: ");

        Articulo articulo = articulos.Find(a => a.ID == id);

        if (articulo != null)
        {
            Console.WriteLine("Artículo encontrado:");
            Console.WriteLine(articulo);

            Console.WriteLine("Ingrese los nuevos datos del artículo:");

            string nuevoNombre = LeerCadena("Nuevo nombre: ");
            double nuevoPrecio = LeerDouble("Nuevo precio: ");

            articulo.Nombre = nuevoNombre;
            articulo.Precio = nuevoPrecio;

            Console.WriteLine("Artículo editado exitosamente.");
        }
        else
        {
            Console.WriteLine("No se encontró ningún artículo con el ID especificado.");
        }
    }

    static void RegistrarVenta()
    {
        Console.WriteLine("Registrar venta:");

        string cedula = LeerCadena("Ingrese la cédula del usuario que realiza la venta: ");

        Usuario usuario = usuarios.Find(u => u.Cedula == cedula);

        if (usuario != null)
        {
            Console.WriteLine("Usuario encontrado:");
            Console.WriteLine(usuario);

            List <Articulo> articulosVenta = new List<Articulo>();
            List<int> cantidades = new List<int>();
            bool agregarArticulo = true;
            while (agregarArticulo)
            {
                Console.WriteLine("Seleccione un artículo:");

                MostrarArticulos();

                int id = LeerEntero("Ingrese el ID del artículo: ");

                Articulo articulo = articulos.Find(a => a.ID == id);

                if (articulo != null)
                {
                    int cantidad = LeerEntero("Ingrese la cantidad a comprar: ");

                    articulosVenta.Add(articulo);
                    cantidades.Add(cantidad);

                    Console.WriteLine("Artículo agregado a la venta.");

                    if (articulosVenta.Count >= 20)
                    {
                        Console.WriteLine("Se ha alcanzado el máximo de artículos permitidos por venta.");
                        agregarArticulo = false;
                    }
                    else
                    {
                        string respuesta = LeerCadena("¿Desea agregar otro artículo a la venta? (s/n): ");
                        agregarArticulo = (respuesta.ToLower() == "s");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró ningún artículo con el ID especificado.");
                }
            }

            Venta nuevaVenta = new Venta(usuario, articulosVenta, cantidades);
            ventas.Add(nuevaVenta);

            Console.WriteLine("Venta registrada exitosamente.");

            Console.WriteLine("Factura:");
            Console.WriteLine(nuevaVenta.GenerarFactura());
        }
        else
        {
            Console.WriteLine("No se encontró ningún usuario con la cédula especificada.");
        }
    }

    static int LeerEntero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente nuevamente.");
            }
        }
    }

    static double LeerDouble(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente nuevamente.");
            }
        }
    }

    static string LeerCadena(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }
}

class Usuario
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public string Direccion { get; set; }

    public Usuario(string nombre, string cedula, string direccion)
    {
        Nombre = nombre;
        Cedula = cedula;
        Direccion = direccion;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Cédula: {Cedula}, Dirección: {Direccion}";
    }
}

class Articulo
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Articulo(int id, string nombre, double precio)
    {
        ID = id;
        Nombre = nombre;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Nombre: {Nombre}, Precio: {Precio:C}";
    }
}

class Venta
{
    public Usuario Usuario { get; set; }
    public List<Articulo> Articulos { get; set; }
    public List
        <int> Cantidades
    { get; set; }
    public Venta(Usuario usuario, List<Articulo> articulos, List<int> cantidades)
    {
        Usuario = usuario;
        Articulos = articulos;
        Cantidades = cantidades;
    }

    public string GenerarFactura()
    {
        string factura = $"Usuario: {Usuario.Nombre}\n\n";

        double total = 0;

        for (int i = 0; i < Articulos.Count; i++)
        {
            Articulo articulo = Articulos[i];
            int cantidad = Cantidades[i];

            double subtotal = cantidad * articulo.Precio;
            total += subtotal;

            factura += $"{articulo.Nombre} (x{cantidad}): {subtotal:C}\n";
        }

        factura += $"\nTotal: {total:C}";

        return factura;
    }
}
