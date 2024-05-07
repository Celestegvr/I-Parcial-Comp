using System;
using System.Collections.Generic;

// Clase Repartidor
public class Repartidor
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Identificacion { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Direccion { get; set; }
    public string Celular { get; set; }
    public Moto MotoDetalle { get; set; }

    public Repartidor(string nombre, string apellido, int identificacion, DateTime fechaNacimiento,
                      string direccion, string celular, Moto motoDetalle)
    {
        Nombre = nombre;
        Apellido = apellido;
        Identificacion = identificacion;
        FechaNacimiento = fechaNacimiento;
        Direccion = direccion;
        Celular = celular;
        MotoDetalle = motoDetalle;
    }
}

// Clase Moto
public class Moto
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public bool Alquilada { get; set; }

    public Moto(string placa, string marca, string modelo, int año, bool alquilada)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Alquilada = alquilada;
    }
}

// Clase FacturaVenta
public class FacturaVenta
{
    public int NumFactura { get; set; }
    public DateTime Fecha { get; set; }
    public Cliente Cliente { get; set; }
    public List<DetalleFactura> Detalles { get; set; }

    public FacturaVenta(int numFactura, DateTime fecha, Cliente cliente, List<DetalleFactura> detalles)
    {
        NumFactura = numFactura;
        Fecha = fecha;
        Cliente = cliente;
        Detalles = detalles;
    }
}

// Clase Cliente
public class Cliente
{
    public int NumCliente { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Celular { get; set; }

    public Cliente(int numCliente, string nombre, string apellido, string direccion, string celular)
    {
        NumCliente = numCliente;
        Nombre = nombre;
        Apellido = apellido;
        Direccion = direccion;
        Celular = celular;
    }
}

// Clase DetalleFactura
public class DetalleFactura
{
    public int IdProducto { get; set; }
    public string NombreProducto { get; set; }
    public decimal PrecioUnitario { get; set; }
    public int Cantidad { get; set; }
    public decimal Subtotal => PrecioUnitario * Cantidad;

    public DetalleFactura(int idProducto, string nombreProducto, decimal precioUnitario, int cantidad)
    {
        IdProducto = idProducto;
        NombreProducto = nombreProducto;
        PrecioUnitario = precioUnitario;
        Cantidad = cantidad;
    }
}

// Clase Reclamo
public class Reclamo
{
    public int NumReclamo { get; set; }
    public int NumCliente { get; set; }
    public string Tipo { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaReclamo { get; set; }
    public Repartidor RepartidorAsignado { get; set; }

    public Reclamo(int numReclamo, int numCliente, string tipo, string descripcion,
                   DateTime fechaReclamo, Repartidor repartidorAsignado)
    {
        NumReclamo = numReclamo;
        NumCliente = numCliente;
        Tipo = tipo;
        Descripcion = descripcion;
        FechaReclamo = fechaReclamo;
        RepartidorAsignado = repartidorAsignado;
    }
}
