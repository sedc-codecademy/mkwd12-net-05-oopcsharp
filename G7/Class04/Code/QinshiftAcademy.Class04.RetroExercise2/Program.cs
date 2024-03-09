string[] names = new string[0];

while (true)
{
    Console.WriteLine("Please enter a name");
    string name = Console.ReadLine();

    Array.Resize(ref names, names.Length + 1);
    names[names.Length - 1] = name;


    Console.WriteLine("Would you like to continue");
    string choice = Console.ReadLine();
    if (choice == "N" || choice == "n")
    {
        break;
    }
}

foreach(string name in names)
{
    Console.WriteLine("Name: " + name);
}


//[] , input: Tanja -> [Tanja] names[1-1] = Tanja
//[Tanja], input: Aleksandar -> [Tanja, Aleksandar] names[2-1] = Aleksandar
//[Tanja, Aleksandar], input: Marko -> [Tanja, Aleksandar, Marko] names[3-1] = Marko