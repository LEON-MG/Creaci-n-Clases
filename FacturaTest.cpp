#include <iostream>
using namespace std;
class Factura {
    public:
    string numPieza;
    string descripcion;
    int cantidad;
    double precio;
    
    Factura(){
        numPieza="";
        descripcion="";
        cantidad=0;
        precio=0.0;
        
    }
    
    double obtenerMontoFactura (){
    return cantidad*precio;
    }
};
int main(){
    Factura ferre;
    cout<<"Numero de pieza: "; cin>>ferre.numPieza;
    cout<<"Descripción: "; cin>>ferre.descripcion;
    cout<<"Cantidad: "; cin>>ferre.cantidad;
    cout<<"Precio: "; cin>>ferre.precio;
    
    if(ferre.precio<0) ferre.precio=0.0;
    if(ferre.cantidad<0) ferre.precio=0;
    
    cout<<"Factura: "<<ferre.obtenerMontoFactura()<<endl;
    return 0;
}