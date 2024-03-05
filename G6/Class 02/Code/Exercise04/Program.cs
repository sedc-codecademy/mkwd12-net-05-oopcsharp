//You have n credits on your mobile bill. One SMS costs m credits. How many SMS messages you can send?
//n = 102
//m = 5
//Result = ?

int credits = 102;
int messageCost = 5;
int messagesSent = credits / messageCost;
Console.WriteLine($"You can send: {messagesSent} messages");