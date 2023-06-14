Console.Write("Введите число 1 =>");
string inputedString1 = Console.ReadLine(); 
Console.Write("Введите число 2 =>"); 
string inputedString2 = Console.ReadLine(); 
Console.Write("Введите число 3 =>"); 
string inputedString3 = Console.ReadLine(); 

int number1 = Convert.ToInt32(inputedString1);
int number2 = Convert.ToInt32(inputedString2);
int number3 = Convert.ToInt32(inputedString3);
int max=number1;

if (number1>number2)
{
   if (number1>number3) 
   {
    Console.WriteLine("Большее число " + number1);
   } else Console.WriteLine("Большее число " + number3);

   
}else
if (number2>number3)
{
    Console.WriteLine("Большее число " + number2);
}
else 
Console.WriteLine("Большее число " + number3);