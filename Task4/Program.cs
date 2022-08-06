// программа, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N

Console.Write("Let's find all even numbers from 1 to N. Input your N : ");
double N = Convert.ToInt32(Console.ReadLine());

double count = 1, rem = 1;

Console.Write("From 1 to " + N + " even numbers are: ");

while(count < N + 1)
{
    rem = count % 2;
    if (rem == 0) Console.Write(count + ", ");
    count = count + 1;
}