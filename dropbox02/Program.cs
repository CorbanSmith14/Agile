//Input
Console.WriteLine("Enter change amount:");
//Back End
decimal changeAmount = decimal.Parse(Console.ReadLine());
int changeInCents = (int)(changeAmount * 100);
int numberOfQuarters = changeInCents / 25;
int remainderAfterQuaters = changeInCents % 25;
int numberOfDimes = remainderAfterQuaters / 10;
int remainderAfterDimes = remainderAfterQuaters % 10;
int numberOfNickels = remainderAfterDimes / 5;
int remainderAfterNickels = remainderAfterDimes % 5;
int numberOfPennies = remainderAfterNickels;
// Display
Console.WriteLine($"Number of Quarters : {numberOfQuarters}");
Console.WriteLine($"Number of Dimes : {numberOfDimes}");
Console.WriteLine($"Number of Nickels : {numberOfNickels}");
Console.WriteLine($"Number of Pennies : {numberOfPennies}");