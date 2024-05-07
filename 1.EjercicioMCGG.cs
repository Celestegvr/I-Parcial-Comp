using System;
using System.Collections.Generic;

// Clase Cliente
public class Cliente
{
    public int Codigo {get; set; }
    public string Nombre {get; set; }
    public string Apellido {get; set; }
    public string Telefono {get; set; }
    public string Direccion {get; set; }
  
}

// Clase Proveedor
public class Proveedor
{
    public int Codigo {get; set; }
    public string Nombre {get; set; }
    public string Contacto {get; set; }
    
}

public class ContactoProveedor : Proveedor
{
    public string Cargo {get; set; }
    
}


public class Producto
{
    public int Num {get; set; }
    public string Nombre {get; set; }
    public string Marca {get; set; }
    public string Color {get; set; }
    public string Estilo {get; set; }
    public string Talla {get; set; }
    public string TipoTela {get; set; }
    public string Origen {get; set; }
   
}

public class Compra
{
    public int NumCompra { get; set; }
    public string TipoCompra { get; set; }
    public string DocSoporte { get; set; }
    public string Descripcion { get; set; }
    public int NumProveedor { get; set; }
    public int NumEmpleado { get; set; }
    public decimal SubtotalCompra { get; set; }
    public decimal Descuento { get; set; }
    public decimal ImpuestoCompra { get; set; }
    public decimal TotalCompra { get; set; }
    public List<DetalleCompra> Detalles { get; set; } 
   

    public Compra()
    {
        Detalles = new List<DetalleCompra>();
    }
}

// Clase DetalleCompra
public class DetalleCompra
{
    public int NumDetalleCompra {get; set; }
    public int CodProducto {get; set; }
    public int Cantidad {get; set; }
    public decimal PrecioCompra {get; set; }
    public decimal SubtotalCompra {get; set; }
    
}

public class Pago
{
    public int NumPago { get; set; }
    public string TipoPago { get; set; }
    public DateTime FechaPago { get; set; }
    public int NumCompra { get; set; }
    public string Descripcion { get; set; }
    public decimal Retencion { get; set; }
    public decimal MontoPago { get; set; }
    public string NumCheque { get; set; }
  
}
class Program
{
    static List<Compra> compras = new List<Compra>();
    static List<Pago> pagos = new List<Pago>(); // Lista de pagos realizados a proveedores

    static void Main(string[] args)
    {
        Console.WriteLine("\tBienvenido a Las 4B - Sistema de Gestión\n");
        Console.WriteLine("1. Registrar Venta\n");
        Console.WriteLine("2. Realizar Pago a Proveedor\n");
        Console.WriteLine("3. Ver Registro de Venta\n");
        Console.WriteLine("4. Ver Registro de Pagos a Proveedores\n");
        Console.WriteLine("5. Salir\n");

        int opcion;
        do
        {
            Console.Write("Por favor, seleccione una opción: \n");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarVenta();
                    break;
                case 2:
                    RealizarPagoProveedor();
                    break;
                case 3:
                    VerRegistroVenta();
                    break;
                case 4:
                    VerRegistroPagos();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        } while (opcion != 5);
    }

    static void RegistrarVenta()
    {
        Console.WriteLine("Registro de Venta");


        Console.Write("Ingrese el nombre del cliente: ");
        string nombreCliente = Console.ReadLine();

        Console.Write("Ingrese el total de la venta: ");
        decimal totalVenta = Convert.ToDecimal(Console.ReadLine());

        Compra venta = new Compra
        {
            NumCompra = compras.Count + 1, 
            TipoCompra = "Venta",
            Descripcion = "Venta realizada a cliente",
            SubtotalCompra = totalVenta, 
            TotalCompra = totalVenta
        };

        compras.Add(venta);

        Console.WriteLine("Venta registrada exitosamente.");
    }

    static void RealizarPagoProveedor()
    {
        Console.WriteLine("Realizar Pago a Proveedor");

        

        Console.Write("Ingrese el número de compra: ");
        int numCompra = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el monto del pago: ");
        decimal montoPago = Convert.ToDecimal(Console.ReadLine());

        Compra compra = compras.Find(c => c.NumCompra == numCompra);
        if (compra != null)
        {
    
            Pago pago = new Pago
            {
                NumPago = compra.NumCompra, 
                TipoPago = "Pago a Proveedor",
                FechaPago = DateTime.Now,
                NumCompra = compra.NumCompra,
                Descripcion = "Pago realizado al proveedor por la compra",
                MontoPago = montoPago
            };

            List<Pago> pagos = new List<Pago>();
            pagos.Add(pago);

            Console.WriteLine("Pago realizado al proveedor registrado exitosamente.");
        }
        else
        {
            Console.WriteLine("No se encontró la compra correspondiente al número ingresado.");
        }
    }
    static void VerRegistroVenta()
    {
        Console.WriteLine("Registro de Ventas:");

        foreach (var venta in compras)
        {
            Console.WriteLine($"Número de Compra: {venta.NumCompra}, Total: {venta.TotalCompra}");
        }
    }
    static void VerRegistroPagos()
    {
        Console.WriteLine("Registro de Pagos a Proveedores:");

        foreach (var pago in pagos)
        {
            Console.WriteLine($"Número de Pago: {pago.NumPago}, Monto: {pago.MontoPago}");
        }
    }

}
