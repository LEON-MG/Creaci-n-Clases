#include <iostream>

using namespace std;

class Fecha {

    public:

    int mes;
    int dia;
    int año;

    Fecha() {

        mes = 0;
        dia = 0;
        año = 0;
    }

    void mostrarFecha() {

        cout << mes << "/"
             << dia << "/"
             << año << endl;
    }

};

int main() {

    Fecha fecha;

    cout << "Ingresa el mes: ";
    cin >> fecha.mes;

    cout << "Ingresa el dia: ";
    cin >> fecha.dia;

    cout << "Ingresa el año: ";
    cin >> fecha.año;

    cout << "Fecha: ";

    fecha.mostrarFecha();

    return 0;
}