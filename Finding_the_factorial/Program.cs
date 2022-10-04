//считет максимальное 20

string s = String.Empty;
Console.WriteLine(s);
Console.Write("Введите значение факториала: ");

long factorial = Convert.ToInt64(Console.ReadLine());
long current = 1;
int miltiplier = 1;

if (factorial == 0)
{
    Console.WriteLine($"Факториал равен: {current}");
    Console.WriteLine(s);
}

for (long m = miltiplier; m <= factorial; m++)

    {
        current = current * m;
    }
    
Console.WriteLine($"Факториал равен: {current}");
Console.WriteLine(s);


