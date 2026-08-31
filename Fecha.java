public class Fecha {

    int mes;
    int dia;
    int anio;

    Fecha() {

        mes = 0;
        dia = 0;
        anio = 0;
    }

    void mostrarFecha() {

        System.out.println(
            mes + "/" + dia + "/" + anio
        );
    }
}