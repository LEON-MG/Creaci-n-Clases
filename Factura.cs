public class Factura
{
    public string numPieza;
    public string descripcion;
    public int cantidad;
    public double precio;

    public Factura()
    {
        numPieza = "";
        descripcion = "";
        cantidad = 0;
        precio = 0.0;
    }

    public double obtenerMontoFactura()
    {
        return cantidad * precio;
    }
}