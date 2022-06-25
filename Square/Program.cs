//Напишите метод, который отображает квадрат из
//некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.


Console.WriteLine("Input side length of a square");
int l = int.Parse(Console.ReadLine());
Console.WriteLine("Input sing");
char s = char.Parse(Console.ReadLine());
Console.WriteLine("");
for (int i = 0; i < l; i++)
{
    for (int j = 0; j < l; j++)
    {
        Console.Write(s);
    }
    Console.WriteLine();
}
Console.WriteLine("");// Дырявый вариант 
for (int i = 0; i < l; i++)
{
    for (int j = 0; j < l; j++)
    {
        if (i == 0 || j == 0 || i == (l - 1) || j == (l - 1))
            Console.Write(s);
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

