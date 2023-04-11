//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

int a =  new Random().Next(1,100);
Console.WriteLine("El primer numero es: " );
Console.WriteLine(a);
int b =  new Random().Next(1,100);
Console.WriteLine("El segundo numero es: " );
Console.WriteLine(b);
if (a<b)
{
  Console.WriteLine("El numero mayor es : ");
  Console.WriteLine(b);  
}
else
{
  Console.WriteLine("El numero mayor es : "); 
  Console.WriteLine(a);   
}



