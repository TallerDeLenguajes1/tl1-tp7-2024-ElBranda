using EspacioCalculadora;

Console.WriteLine("Hello, World!");

Calculadora calculadora = new Calculadora();

while (true) {
    Console.WriteLine("1. +");
    Console.WriteLine("2. -");
    Console.WriteLine("3. *"); //a
    Console.WriteLine("4. /");
    Console.WriteLine("5. CLR");
    Console.WriteLine("6. RES");
    Console.WriteLine("7. EXIT");

    int com = Convert.ToInt32(Console.ReadLine());

    if (com == 5) calculadora.Limpiar();
    else if (com == 6) Console.WriteLine(calculadora.Resultado);
    else if (com == 7) break;
    else {
        double n = Convert.ToDouble(Console.ReadLine());

        switch (com) {
            case 1: calculadora.Sumar(n); break;
            case 2: calculadora.Restar(n); break;
            case 3: calculadora.Multiplicar(n); break;
            case 4: calculadora.Dividir(n); break;
        }
    }
}
