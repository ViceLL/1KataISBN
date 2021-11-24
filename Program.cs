int ISBN = 0;
Console.WriteLine("Ingrese que formato de ISBN (10 o 13) desea validar: ");
ISBN = int.Parse(Console.ReadLine());
Console.WriteLine("Ingreso: " + ISBN);

if(ISBN == 10)
{
    int suma10 = 0;
    int[] ISBN10 = new int[10];

    for (int i = 9; i >= 0; i--)
    {
        Console.WriteLine("Ingrese un numero: ");
        ISBN10[i] = int.Parse(Console.ReadLine());

        if (ISBN10[i] < 0 || ISBN10[9] > 9)
        {
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("[" + i + "]" + "->" + ISBN10[i]);
            suma10 += ISBN10[i] * (i + 1);
        }

        Console.WriteLine("La suma suma codigo[10] es: " + suma10);
    }
    if (suma10 % 11 == 0)
    {
        Console.WriteLine("El codigo es valido.");
    }
    else
    {
        Console.WriteLine("El codigo es invalido.");
    }
}
else if (ISBN == 13)
{
    int suma13a = 0, suma13b = 0, suma13t = 0;
    int[] ISBN13 = new int[13];

    for (int i = 12; i >= 0; i--)
    {
        Console.WriteLine("Ingrese un numero: ");
        ISBN13[i] = int.Parse(Console.ReadLine());
    
        if (ISBN13[i] < 0 || ISBN13[9] > 9)
        {
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("[" + i + "]" + "->" + ISBN13[i]);

            if ((i + 1) % 2 == 0)
            {
                suma13a += ISBN13[i] * 3;
            }
            else
            {
                suma13b += ISBN13[i] * 1;
            }
        }
    }
    suma13t = suma13a + suma13b;
    if (suma13t % 10 == 0)
    {
        Console.WriteLine("El codigo es valido.");
    }
    else
    {
        Console.WriteLine("El codigo es invalido.");
    }
}
else
{
    Console.WriteLine("Este formato de ISBN no existe.");
}
