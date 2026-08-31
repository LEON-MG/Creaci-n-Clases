public class Fecha
{
    public int mes;
    public int dia;
    public int anio;

    public Fecha()
    {
        mes = 0;
        dia = 0;
        anio = 0;
    }

    public void mostrarFecha()
    {
        System.Console.WriteLine(
            mes + "/" + dia + "/" + anio
        );
    }
}