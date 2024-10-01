//Input
Console.WriteLine("How many cookies would you like to buy?");
//Back End

int numberOfCookies = int.Parse(Console.ReadLine());
double totalCost; 
if (numberOfCookies >= 12)
{
    int dozens = numberOfCookies / 12;
    int remainder = numberOfCookies % 12;
    totalCost = dozens * 1.20 + remainder * 0.12;
}
else
{
    totalCost = numberOfCookies * 0.12;
}

//Display
Console.WriteLine($"The total cost for {numberOfCookies} cookies is ${totalCost:F2}");