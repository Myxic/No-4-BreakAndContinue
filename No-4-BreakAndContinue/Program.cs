// See https://aka.ms/new-console-template for more information

for (int i = 0; i < 6; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

for (int i = 0; i < 6; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}

