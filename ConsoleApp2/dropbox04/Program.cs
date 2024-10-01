//Input
int[] scores = new int[5];
//Loop
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine("Enter a score:");
    scores[i] = int.Parse(Console.ReadLine());
}
//Display
Console.WriteLine($"Average: {scores.Average():N2}");
Console.WriteLine($"Highest: {scores.Max()}");
Console.WriteLine($"Lowest: {scores.Min()}");
//Display scores in order
foreach(int s in scores.OrderByDescending(x=>x))
{
    Console.WriteLine(s+" ");
}