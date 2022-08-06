// программа, которая на вход принимает число и выдаёт, 
// является ли число чётным

Console.Write("Input number: ");
double num = Convert.ToInt32(Console.ReadLine());

double rem = num % 2;

if (rem == 0) Console.WriteLine(num + " is an even number"); //простите, у меня терминал не воспринимает кириллицу, пишу на английском. even - переводится, как "четное"
else Console.WriteLine(num + " is NOT an even number");

 