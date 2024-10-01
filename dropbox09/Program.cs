namespace Chapter5Example2
{
    class Program
    {
        static void Main()
        {
            Board board = new Board();
            Console.WriteLine(board);
            CellValue playerName = CellValue.X;
                int row;
            int col;
            bool playerWins = false;
            bool stalemate = false;
            while(!(playerWins || stalemate))
            {
                do
                {
                    Console.WriteLine($"Player {playerName} moves.");
                    Console.WriteLine("Enter row number (0, 1, 2):");
                    row = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter column number(0, 1, 2):");
                    col = int.Parse(Console.ReadLine()!);
                    if (board.AllCells[row, col] != CellValue.E)
                        Console.WriteLine("invalid move");
                }
                while (board.AllCells[row, col] != CellValue.E);
                Player player = new Player(playerName, row, col);
                player.PlayerMove(board);
                Console.WriteLine(board);
                playerWins = player.IsPlayerWin(board);
                stalemate = board.HasNoMoreE();
                if (playerWins)
                    Console.WriteLine($"Player{playerName}wins.");
                if (stalemate)
                    Console.WriteLine($"Stalemate!");
                playerName = (playerName == CellValue.X) ?
                    CellValue.O : CellValue.X;
                    
            }
        }
    }
}