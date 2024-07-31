using EspacioEmpresa;

Console.WriteLine("Hello, World!");
Console.WriteLine();

Empleado[] empleados =
[
    new Empleado("Juan", "Lopez", new DateTime(2003, 10, 10), '1', new DateTime(2020, 10, 10), 850000, Empleado.Cargo.Auxiliar),
    new Empleado("Jose", "Gomez", new DateTime(1998, 3, 15), '0', new DateTime(2018, 10, 10), 1500000, Empleado.Cargo.Ingeniero),
    new Empleado("Hernan", "Hernandez", new DateTime(2005, 5, 7), '1', new DateTime(2023, 10, 10), 1000000, Empleado.Cargo.Investigador),
];

double montoTotal=0;
int yamejubilo=0, index=0;

for (int i = 0; i < empleados.Length; i++) {
    montoTotal += empleados[i].Sueldo();

    if (empleados[i].Antiguedad() > yamejubilo) {
        yamejubilo = empleados[i].Antiguedad();
        index = i;
    }
}

Console.WriteLine("Monto TOTAL: " + Math.Round(montoTotal, 2));

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("EMPLEADO: " + empleados[index].NombreCompleto());
Console.WriteLine("Antigüedad: " + empleados[index].Antiguedad());
Console.WriteLine("Edad: " + empleados[index].Edad());
Console.WriteLine("Años para jubilarse: " + empleados[index].Jubilacion());
Console.WriteLine("Sueldo: " + Math.Round(empleados[index].Sueldo(), 2));