using EspacioCalculadora;


Calculadora calcu = new Calculadora();
int opcion;
double valor;
bool seguir = true;

while (seguir) {
    Console.WriteLine($"\nResultado actual: {calcu.GetResultado()}");
    Console.WriteLine("Ingrese el numero de la operacion que quiera realizar:");
    Console.WriteLine("1-Sumar.");
    Console.WriteLine("2-Restar.");
    Console.WriteLine("3-Multiplicar.");
    Console.WriteLine("4-Dividir.");
    Console.WriteLine("5-Limpiar.");
    Console.WriteLine("6-Salir.");

    while (!int.TryParse(Console.ReadLine(), out opcion)) {
        Console.WriteLine("Opción inválida, elija un número entre 1 y 6.");
    }

    if (opcion == 6)
    {
        Console.WriteLine("Saliendo de la calculadora...");
        seguir = false;
        break;
    }

    Console.WriteLine("Ingrese el numero al cual se le realizarà la operaciòn elegida:");
    while (!double.TryParse(Console.ReadLine(), out valor)) {
        Console.WriteLine("Numero invàlido, ingrese otro.");
    }

    switch (opcion)
    {
        case 1:
            calcu.Sumar(valor);
            break;
        case 2:
            calcu.Restar(valor);
            break;
        case 3:
            calcu.Multiplicar(valor);
            break;
        case 4:
            calcu.Dividir(valor);
            break;
        case 5:
            calcu.Limpiar();
            Console.WriteLine("Calculadora reiniciada.");
            break;
    }
}
    