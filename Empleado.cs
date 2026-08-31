public class Empleado
{
    public string nombre;
    public string apellido;
    public double salario;

    public Empleado()
    {
        nombre = "";
        apellido = "";
        salario = 0.0;
    }

    public double obtenerSalarioAnual()
    {
        return salario * 12;
    }

    public void aumentarSalario()
    {
        salario = salario * 1.10;
    }
}