using System.ComponentModel.Design;
using System.Data;
class Program
{
    static string UserShape()
    {
        string str;
        str = "ROCK";
        bool isCorrectSpelling = false;
        while (!isCorrectSpelling)
        {
            Console.WriteLine("Enter Rock,Paper, or Scissors:");
            str = Console.ReadLine().ToUpper();
            isCorrectSpelling = true;
        }
        return str;
    }
    static string ComputerShape()
    {
        string str;
        str = "PAPER";
        Random random = new Random();
        int randomNumber = random.Next(1, 4);
        switch (randomNumber)
        {
            case 1:
                str = "ROCK";
                    break;
            case 2:
                str = "PAPER";
                    break;
            case 3:
                str = "SCISSORS";
                    break;
        }
        return str;
    }
    static string Winner(string user,string computer)
    {
        string winner = "Nobody";
        if (user == "ROCK" && computer == "PAPER"
            || user == "PAPER" && computer == "SCISSORS"
            || user == "SCISSORS" && computer == "Rock")
            winner = "computer";
        else if (user == "ROCK" && computer == "SCISSORS"
            || user == "PAPER" && computer == "ROCK"
            || user == "SCISSORS" && computer == "PAPER")
            winner = "Player";
            return winner;
    }
    static bool PlayAgain()
    {
        Console.WriteLine("Play Again? (Y/N)");
        string choice = Console.ReadLine().ToUpper();
        return choice == "Y" || choice == "YES";
    }
    static void Main()
    {
            bool playAgain = true;

            while (playAgain)
            {
                int playerScore = 0;
                int computerScore = 0;
                int roundsPlayed = 0;

                while (roundsPlayed < 3)
                {
                    string userShape = UserShape();
                    string computerShape = ComputerShape();
                    string winner = Winner(userShape, computerShape);

                    Console.WriteLine($"User Shape: {userShape}");
                    Console.WriteLine($"Computer Shape: {computerShape}");
                    Console.WriteLine($"The Winner is: {winner}");

                    if (winner == "Player")
                    {
                        playerScore++;
                    }
                    else if (winner == "Computer")
                    {
                        computerScore++;
                    }

                    roundsPlayed++;

                    Console.WriteLine();
                }

                Console.WriteLine($"Final Score: Player {playerScore} - {computerScore} Computer");

                if (playerScore > computerScore)
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (playerScore < computerScore)
                {
                    Console.WriteLine("Computer Wins!");
                }
                else
                {
                    Console.WriteLine("Tie!");
                }

                playAgain = PlayAgain();

                Console.WriteLine();
            }

            Console.WriteLine("Thanks for playing!");
    }
}