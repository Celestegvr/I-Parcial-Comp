using System.Collections.Generic;

public class Repartidor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Identificacion { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Direccion { get; set; }
    public string Celular { get; set; }
    public string DetallesMoto { get; set; } // Detalles de la moto
    public bool EsAlquilada { get; set; }
}

public class Factura
{
    public int NumeroFactura { get; set; }
    public DateTime Fecha { get; set; }
    public int NumeroCliente { get; set; }
    public List<int> Productos { get; set; } // Lista de códigos de productos
    public int IdRepartidor { get; set; }
}

public class Reclamo
{
    public int NumeroReclamo { get; set; }
    public int NumeroCliente { get; set; }
    public string Tipo { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaReclamo { get; set; }
}

class Program
{
    static List<Repartidor> repartidores = new List<Repartidor>();
    static List<Factura> facturas = new List<Factura>();
    static List<Reclamo> reclamos = new List<Reclamo>();

    static void Main(string[] args)
    {
        CrearRepartidoresEjemplo();



        // Crear facturas de ejemplo
        CrearFacturasEjemplo();



        // Crear reclamos de ejemplo
        CrearReclamosEjemplo();
        Console.WriteLine("Bienvenido al Sistema de Pedidos Ya");

        int opcion;
        do
        {
            MostrarMenu();
            Console.Write("Por favor, seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Mostrar información de los repartidores
                    MostrarInformacionRepartidores();
                    break;
                case 2:
                    // Mostrar registro de facturas
                    MostrarRegistroFacturas();
                    break;
                case 3:
                    // Mostrar reclamos
                    MostrarReclamos();
                    break;
                case 4:
                    MostrarReclamos();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        } while (opcion != 6);



    }

    static void MostrarMenu()
    {
        Console.WriteLine("Menú:");
        Console.WriteLine("1. Ver Registro de Repartidores");
        Console.WriteLine("2. Ver Registro de Facturas");
        Console.WriteLine("3. Ver Reclamos");
        Console.WriteLine("4. Salir");
    }

    static void CrearRepartidoresEjemplo()
    {
        repartidores.Add(new Repartidor
        {
            Id = 1,
            Nombre = "Juan",
            Apellido = "Perez",
            Identificacion = "123456789",
            FechaNacimiento = new DateTime(1990, 5, 15),
            Direccion = "Calle 123",
            Celular = "987654321",
            DetallesMoto = "Honda CB500X, Placa: ABC-123, Año: 2020",
            EsAlquilada = false
        });

        repartidores.Add(new Repartidor
        {
            Id = 2,
            Nombre = "María",
            Apellido = "Gomez",
            Identificacion = "987654321",
            FechaNacimiento = new DateTime(1992, 8, 25),
            Direccion = "Avenida Principal",
            Celular = "123456789",
            DetallesMoto = "Yamaha MT-07, Placa: XYZ-987, Año: 2019",
            EsAlquilada = true
        });
    }

    static void MostrarInformacionRepartidores()
    {
        Console.WriteLine("Información de Repartidores:");
        foreach (var repartidor in repartidores)
        {
            Console.WriteLine($"ID: {repartidor.Id}, Nombre: {repartidor.Nombre} {repartidor.Apellido}");
            Console.WriteLine($"Identificación: {repartidor.Identificacion}");
            Console.WriteLine($"Fecha de Nacimiento: {repartidor.FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Dirección: {repartidor.Direccion}");
            Console.WriteLine($"Celular: {repartidor.Celular}");
            Console.WriteLine($"Detalles Moto: {repartidor.DetallesMoto}");
            Console.WriteLine($"Es Alquilada: {(repartidor.EsAlquilada ? "Sí" : "No")}");
            Console.WriteLine();
        }
    }

    static void CrearFacturasEjemplo()
    {
        facturas.Add(new Factura
        {
            NumeroFactura = 1,
            Fecha = DateTime.Now,
            NumeroCliente = 1001,
            Productos = new List<int> { 101, 102 },
            IdRepartidor = 1
        });

        facturas.Add(new Factura
        {
            NumeroFactura = 2,
            Fecha = DateTime.Now,
            NumeroCliente = 1002,
            Productos = new List<int> { 103, 104 },
            IdRepartidor = 2
        });
    }

    static void MostrarRegistroFacturas()
    {
        Console.WriteLine("Registro de Facturas:");
        foreach (var factura in facturas)
        {
            Console.WriteLine($"Número de Factura: {factura.NumeroFactura}");
            Console.WriteLine($"Fecha: {factura.Fecha}");
            Console.WriteLine($"Número de Cliente: {factura.NumeroCliente}");
            Console.WriteLine($"Productos: {string.Join(", ", factura.Productos)}");
            Console.WriteLine($"ID Repartidor: {factura.IdRepartidor}");
            Console.WriteLine();
        }
    }

    static void CrearReclamosEjemplo()
    {
        reclamos.Add(new Reclamo
        {
            NumeroReclamo = 1,
            NumeroCliente = 1001,
            Tipo = "Producto Defectuoso",
            Descripcion = "El producto recibido no funciona correctamente.",
            FechaReclamo = DateTime.Now
        });

        reclamos.Add(new Reclamo
        {
            NumeroReclamo = 2,
            NumeroCliente = 1002,
            Tipo = "Entrega Tardía",
            Descripcion = "El pedido se entregó con retraso.",
            FechaReclamo = DateTime.Now
        });
    }

    static void MostrarReclamos()
    {
        Console.WriteLine("Reclamos:");
        foreach (var reclamo in reclamos)
        {
            Console.WriteLine($"Número de Reclamo: {reclamo.NumeroReclamo}");
            Console.WriteLine($"Número de Cliente: {reclamo.NumeroCliente}");
            Console.WriteLine($"Tipo: {reclamo.Tipo}");
            Console.WriteLine($"Descripción: {reclamo.Descripcion}");
            Console.WriteLine($"Fecha de Reclamo: {reclamo.FechaReclamo}");
            Console.WriteLine();
        }
    }
}