using System;

class FacturaTest
{
    static void Main()
    {
        Factura ferre = new Factura();

        Console.WriteLine("Ingresa el número de pieza: ");
        ferre.numPieza = Console.ReadLine();

        Console.WriteLine("Agrega la descripción: ");
        ferre.descripcion = Console.ReadLine();

        Console.WriteLine("Cantidad: ");
        ferre.cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Precio: ");
        ferre.precio = double.Parse(Console.ReadLine());

        if (ferre.precio < 0)
            ferre.precio = 0.0;

        if (ferre.cantidad < 0)
            ferre.cantidad = 0;

        Console.WriteLine("Factura: " + ferre.obtenerMontoFactura());
    }
}