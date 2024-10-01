using System.Xml.Linq;
using System;
using System.Text.RegularExpressions;
//Months of the year
string[] MONTHS;

MONTHS = new string[12] {"Janruary",
"Feburary",
"March",
"April",
"May",
"June",
"July",
"August",
"September",
"October",
"November",
"December", };

int[] rainfall = new int[12];

//Loop tp collect
//data for rainfall
for (int i = 0; i < rainfall.Length; i++)
{
    Console.WriteLine($"Enter amount of rainfall in inches for {MONTHS[i]} : ");
    rainfall[i] = int.Parse(Console.ReadLine());
}

//Display
Console.WriteLine($"Average Rainfall for the Year (in inches): {rainfall.Average():N2}");
Console.WriteLine($"Highest Recorded Rainfall for the Year (in inches): {rainfall.Max()}");
Console.WriteLine($"Lowest Recorded Rainfall for the Year (in inches): {rainfall.Min()}");
//Display scores in order

foreach (int s in rainfall.OrderByDescending(x => x))
{
    Console.WriteLine(s + " ");
}