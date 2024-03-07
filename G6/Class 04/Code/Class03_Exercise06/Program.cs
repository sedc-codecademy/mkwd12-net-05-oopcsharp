//Create an array with names
//Give an option to the user to enter a name from the keyboard
//After entering the name put it in the array
//Ask the user if they want to enter another name(Y / N)
//Do the same process over and over until the user enters N
//Print all the names after user enters N

string[] names = new string[0]; //empty array => 0 represents number of elements
//string[] names = new string[] {}; //empty array => 0 represents number of elements
int counter = 0;

while (true)
{
    Console.WriteLine("Enter a name: ");
    string name = Console.ReadLine();

    //we change the size of the array
    Array.Resize(ref names, names.Length + 1);// in the first iteration the length is 0 and we want it to become 1, so we add 1
    names[counter] = name; //we initialize the array element with the name input 
    counter++; //we increment the counter

    Console.WriteLine("Do you want to enter another name(Y / N)");
    string input = Console.ReadLine();
    if(input == "N" || input == "n")
    {
        break;
    }
}