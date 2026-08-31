class Empleado:

    def __init__(self):

        self.nombre = ""
        self.apellido = ""
        self.salario = 0.0

    def obtenerSalarioAnual(self):

        return self.salario * 12

    def aumentarSalario(self):

        self.salario = self.salario * 1.10


empleado1 = Empleado()
empleado2 = Empleado()


empleado1.nombre = input("Ingresa el nombre del empleado 1: ")
empleado1.apellido = input("Ingresa el apellido paterno: ")
empleado1.salario = float(input("Ingresa el salario mensual: "))

empleado1.salario = 0 if empleado1.salario < 0 else empleado1.salario


empleado2.nombre = input("\nIngresa el nombre del empleado 2: ")
empleado2.apellido = input("Ingresa el apellido paterno: ")
empleado2.salario = float(input("Ingresa el salario mensual: "))

empleado2.salario = 0 if empleado2.salario < 0 else empleado2.salario


print("\nSalario anual de",
      empleado1.nombre, ":",
      empleado1.obtenerSalarioAnual())

print("Salario anual de",
      empleado2.nombre, ":",
      empleado2.obtenerSalarioAnual())


empleado1.aumentarSalario()
empleado2.aumentarSalario()


print("\nDespués del aumento del 10%:")

print("Salario anual de",
      empleado1.nombre, ":",
      empleado1.obtenerSalarioAnual())

print("Salario anual de",
      empleado2.nombre, ":",
      empleado2.obtenerSalarioAnual())