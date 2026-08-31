public class Factura {

    String numPieza;
    String descripcion;
    int cantidad;
    double precio;
    
    Factura(){
        numPieza = "";
        descripcion = "";
        cantidad = 0;
        precio = 0.0;
    }
    
    double obtenerMontoFactura (){
        return cantidad*precio;
    }
}