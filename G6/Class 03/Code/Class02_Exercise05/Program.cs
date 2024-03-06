//Solve the following problem. On one tree there are 12 branches with n apples on them. 
// One basket can hold m apples. If a user enters number of trees find out how many baskets does it take to collect all 
//    the apples from the trees?
//n = 8
//m = 5
//Result = ?

int numberOfBranchesPerTree = 12;
int applesPerBranch = 8;
int appplesInBasket = 5;
int numberOfTrees; 

Console.WriteLine("Please enter number of trees:");
string input = Console.ReadLine(); //the input from Console.ReadLine() is ALWAYS a STRING

bool success = int.TryParse(input, out numberOfTrees); //we need to parse the input before storing the value in numberOfTrees
int result;
if (success)
{
    int numberOfApples = numberOfTrees * numberOfBranchesPerTree * applesPerBranch;
    Console.WriteLine("Number of apples: " + numberOfApples);

     if(numberOfApples % appplesInBasket == 0)
    {
        result = numberOfApples / appplesInBasket;
    }
    else
    {
        result = numberOfApples / appplesInBasket + 1; //we add another basket for the remaining apples (if we get 3.1 we need another basket for that 0.1)
    }

    Console.WriteLine("You need " + result + " baskets");
}
else
{
    Console.WriteLine("Invalid input!");
}