using System;

public class EmpleadoTest
{
    public static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado();
        Empleado empleado2 = new Empleado();

        Console.WriteLine("Ingresa el nombre del empleado 1: ");
        empleado1.nombre = Console.ReadLine();

        Console.WriteLine("Ingresa el apellido paterno: ");
        empleado1.apellido = Console.ReadLine();

        Console.WriteLine("Ingresa el salario mensual: ");
        empleado1.salario = double.Parse(Console.ReadLine());

        if (empleado1.salario < 0)
            empleado1.salario = 0.0;


        Console.WriteLine("\nIngresa el nombre del empleado 2: ");
        empleado2.nombre = Console.ReadLine();

        Console.WriteLine("Ingresa el apellido paterno: ");
        empleado2.apellido = Console.ReadLine();

        Console.WriteLine("Ingresa el salario mensual: ");
        empleado2.salario = double.Parse(Console.ReadLine());

        if (empleado2.salario < 0)
            empleado2.salario = 0.0;


        Console.WriteLine("\nSalario anual de "
            + empleado1.nombre + ": "
            + empleado1.obtenerSalarioAnual());

        Console.WriteLine("Salario anual de "
            + empleado2.nombre + ": "
            + empleado2.obtenerSalarioAnual());


        empleado1.aumentarSalario();
        empleado2.aumentarSalario();


        Console.WriteLine("\nDespués del aumento del 10%:");

        Console.WriteLine("Salario anual de "
            + empleado1.nombre + ": "
            + empleado1.obtenerSalarioAnual());

        Console.WriteLine("Salario anual de "
            + empleado2.nombre + ": "
            + empleado2.obtenerSalarioAnual());
    }
}