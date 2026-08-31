#include <iostream>
#include <string>

using namespace std;

class Empleado {

    public:

    string nombre;
    string apellido;
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

};

int main() {

    Empleado empleado1;
    Empleado empleado2;

    cout << "Ingresa el nombre del empleado 1: ";
    cin >> empleado1.nombre;

    cout << "Ingresa el apellido paterno: ";
    cin >> empleado1.apellido;

    cout << "Ingresa el salario mensual: ";
    cin >> empleado1.salario;

    if (empleado1.salario < 0)
        empleado1.salario = 0.0;


    cout << "\nIngresa el nombre del empleado 2: ";
    cin >> empleado2.nombre;

    cout << "Ingresa el apellido paterno: ";
    cin >> empleado2.apellido;

    cout << "Ingresa el salario mensual: ";
    cin >> empleado2.salario;

    if (empleado2.salario < 0)
        empleado2.salario = 0.0;


    cout << "\nSalario anual de "
         << empleado1.nombre << ": "
         << empleado1.obtenerSalarioAnual() << endl;

    cout << "Salario anual de "
         << empleado2.nombre << ": "
         << empleado2.obtenerSalarioAnual() << endl;


    empleado1.aumentarSalario();
    empleado2.aumentarSalario();


    cout << "\nDespues del aumento del 10%:" << endl;

    cout << "Salario anual de "
         << empleado1.nombre << ": "
         << empleado1.obtenerSalarioAnual() << endl;

    cout << "Salario anual de "
         << empleado2.nombre << ": "
         << empleado2.obtenerSalarioAnual() << endl;

    return 0;
}