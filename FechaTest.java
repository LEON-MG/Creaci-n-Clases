import java.util.Scanner;

public class FechaTest {

    public static void main(String args[]) {

        Fecha fecha = new Fecha();

        Scanner input = new Scanner(System.in);

        System.out.println("Ingresa el mes: ");
        fecha.mes = input.nextInt();

        System.out.println("Ingresa el día: ");
        fecha.dia = input.nextInt();

        System.out.println("Ingresa el año: ");
        fecha.anio = input.nextInt();

        System.out.println("Fecha: ");

        fecha.mostrarFecha();
    }
}