int[] arrayOfIntegers2 = new int[5];
int sum2 = 0;
int j = 0;
while (j < arrayOfIntegers2.Length)
{
    Console.WriteLine("Enter index " + j);
    if (!int.TryParse(Console.ReadLine(), out arrayOfIntegers2[j]))
    {
        Console.WriteLine("That was not a number!");
        continue;
    };
    sum2 += arrayOfIntegers2[j];
    j++;
    if (j == arrayOfIntegers2.Length)
    {
        Console.WriteLine("The result is: " + sum2);
    }
}
Console.ReadLine();