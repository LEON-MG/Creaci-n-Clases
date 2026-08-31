class Fecha:

    def __init__(self):

        self.mes = 0
        self.dia = 0
        self.anio = 0

    def mostrarFecha(self):

        print(
            self.mes,
            "/",
            self.dia,
            "/",
            self.anio
        )


fecha = Fecha()

fecha.mes = int(input("Ingresa el mes: "))

fecha.dia = int(input("Ingresa el día: "))

fecha.anio = int(input("Ingresa el año: "))


print("Fecha:")

fecha.mostrarFecha()