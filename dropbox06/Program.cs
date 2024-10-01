using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

class Program
{
    static void Main ()
    {
        Console.WriteLine("What is the first number?");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the second number?");
        int b = Convert.ToInt32(Console.ReadLine());

        int product = Multiply(a,b);
        Console.WriteLine("The product is:" + product);
    }

    static int Multiply (int a, int b) 
    {
        int product;
        product = a * b;
        return product; 
    }

}
