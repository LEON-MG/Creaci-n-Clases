public class Empleado {

    String nombre;
    String apellido;
    double salario;

    Empleado() {

        nombre = "";
        apellido = "";
        salario = 0.0;
    }

    double obtenerSalarioAnual() {

        return salario * 12;
    }

    void aumentarSalario() {

        salario = salario * 1.10;
    }
}