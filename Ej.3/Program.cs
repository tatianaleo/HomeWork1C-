// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Inserte el numero: ");
int a = int.Parse(Console.ReadLine());
if (a%2==0)
{
  Console.WriteLine("El numero es par");  
}
else{
    Console.WriteLine("El numero es impar");
}