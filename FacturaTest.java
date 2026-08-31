import java.util.Scanner;

public class FacturaTest {
    public static void main(String args[]){
        Factura ferre=new Factura();
        Scanner input=new Scanner(System.in);
        
        System.out.println("Ingresa el  número de pieza: ");
        ferre.numPieza=input.nextLine();
        
        System.out.println("Agrega la descripción: ");
        ferre.descripcion=input.nextLine();
        
        System.out.println("Cantidad: ");
        ferre.cantidad=input.nextInt();
        
        System.out.println("Precio: ");
        ferre.precio=input.nextDouble();
        
        if (ferre.precio<0) ferre.precio=0.0;
        if (ferre.cantidad<0) ferre.cantidad=0;
        
        System.out.println("Factura: "+ferre.obtenerMontoFactura());
    }
}