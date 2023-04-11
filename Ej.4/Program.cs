//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
double n=13;
int index = 2;
if (n<=1)
{
  Console.Write("No hay numeros par positivos desde 1 hasta ");  
  Console.WriteLine(n);
}
while (index<=n)
{
Console.WriteLine(index);
index= index+2;
}