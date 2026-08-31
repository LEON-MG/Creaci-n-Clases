using System;

public class FechaTest
{
    public static void Main(string[] args)
    {
        Fecha fecha = new Fecha();

        Console.WriteLine("Ingresa el mes: ");
        fecha.mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el día: ");
        fecha.dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el año: ");
        fecha.anio = int.Parse(Console.ReadLine());

        Console.WriteLine("Fecha:");

        fecha.mostrarFecha();
    }
}