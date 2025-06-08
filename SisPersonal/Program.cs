using EspacioEmpleados;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado("Luis", "Hernandez", new DateTime(2000, 8, 28), 'S', new DateTime(2019, 10, 23), "580.000", Cargos.Administrativo);
empleados[1] = new Empleado("Rosa", "Constanza", new DateTime(1995, 2, 18), 'C', new DateTime(2010, 2, 8), "650.000", Cargos.Ingeniero);
empleados[2] = new Empleado("Lara", "Colletti", new DateTime(1997, 4, 6), 'S', new DateTime(2017, 7, 13), "690.000", Cargos.Investigador);

//Muestro el total de los salarios:
double totalSalarios = 0;

foreach (Empleado e in empleados)
{
    totalSalarios += e.CalcularSalario();
}

Console.WriteLine($"Monto total en concepto de salarios: {totalSalarios:N2}");

//Busco el próximo empleado a jubilarse
Empleado proximoJubilado = empleados[0];

foreach (Empleado e in empleados)
{
    if (e.GetAniosJubilarse() < proximoJubilado.GetAniosJubilarse())
    {
        proximoJubilado = e;
    }
}

Console.WriteLine("\nEmpleado más próximo a jubilarse:\n");
Console.WriteLine(proximoJubilado.Datos());