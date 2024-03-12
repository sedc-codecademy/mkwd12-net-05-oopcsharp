//Declare a new array of integers with 5 elements
//Initialize the array elements with values from input
//Sum all the values and print the result in the console

int[] ourArray = new int[5];


//initialize each memeber of the array with the input
for (int i = 0; i < ourArray.Length; i++)
{
    Console.WriteLine("Please enter a value for index: " + i);
    string input = Console.ReadLine();
    int number = int.Parse(input); //if the user enters a wrong input it will throw an error
    ourArray[i] = number; //initialize each memeber of the array with the input
}
int sum = 0;
foreach(int num in ourArray)
{
    sum += num;
}

Console.WriteLine("The sum is: " + sum);