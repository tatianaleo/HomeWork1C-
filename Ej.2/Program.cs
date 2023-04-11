// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
Console.Write("Inserte el primer numero: ");
        int a = int.Parse(Console.ReadLine());
Console.Write("Inserte el segundo numero: ");
        int b  = int.Parse(Console.ReadLine());
Console.Write("Inserte el tercer numero: ");
        int c = int.Parse(Console.ReadLine());
    int max = a;
    if (b>max)
    {
      max =  b;
    }
    if (c>max)
    {
        max=c;
    }    
Console.Write("El numero mayor es: ");
Console.Write(max);