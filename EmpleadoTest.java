import java.util.Scanner;

public class EmpleadoTest {

    public static void main(String args[]) {

        Empleado empleado1 = new Empleado();
        Empleado empleado2 = new Empleado();

        Scanner input = new Scanner(System.in);

        System.out.println("Ingresa el nombre del empleado 1: ");
        empleado1.nombre = input.nextLine();

        System.out.println("Ingresa el apellido paterno: ");
        empleado1.apellido = input.nextLine();

        System.out.println("Ingresa el salario mensual: ");
        empleado1.salario = input.nextDouble();

        if (empleado1.salario < 0)
            empleado1.salario = 0.0;

        input.nextLine();

        System.out.println("\nIngresa el nombre del empleado 2: ");
        empleado2.nombre = input.nextLine();

        System.out.println("Ingresa el apellido paterno: ");
        empleado2.apellido = input.nextLine();

        System.out.println("Ingresa el salario mensual: ");
        empleado2.salario = input.nextDouble();

        if (empleado2.salario < 0)
            empleado2.salario = 0.0;

        System.out.println("\nSalario anual de "
            + empleado1.nombre + ": "
            + empleado1.obtenerSalarioAnual());

        System.out.println("Salario anual de "
            + empleado2.nombre + ": "
            + empleado2.obtenerSalarioAnual());

        empleado1.aumentarSalario();
        empleado2.aumentarSalario();

        System.out.println("\nDespués del aumento del 10%:");

        System.out.println("Salario anual de "
            + empleado1.nombre + ": "
            + empleado1.obtenerSalarioAnual());

        System.out.println("Salario anual de "
            + empleado2.nombre + ": "
            + empleado2.obtenerSalarioAnual());
    }
}