using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Example2
{
    internal class Player
    {
        //fields
        private CellValue playerName;
        private int row;
        private int column;
        //properties
        public CellValue PlayerName
        { 
            get { return playerName; }
            set { playerName = value; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        private int Column
        {
            get { return column; }
            set { column = value; }
        }
        //constructor
        public Player(CellValue playerNmame, int row, int column)
        {
            this.playerName = playerNmame;
            this.row = row;
            this.column = column;
        }
        //method
        public void PlayerMove(Board board)
        {
            board.AllCells[Row, Column] = PlayerName;
        }

        public bool IsPlayerWin(Board board)
        {
            bool isWin = false;
            if (board.AllCells[0,0]!=CellValue.E&&
                board.AllCells[0, 0] == board.AllCells[1,1]&&
                board.AllCells[1, 1] == board.AllCells[2,2])
            {
                isWin = true;
            }
            if (board.AllCells[0, 2] != CellValue.E &&
                board.AllCells[0, 2] == board.AllCells[1, 1] &&
                board.AllCells[1, 1] == board.AllCells[2, 0])
            {
                isWin = true;
            }
            for (int r = 0; r < 3; r++)
                {
                    if (board.AllCells[r, 0] != CellValue.E &&
                        board.AllCells[r, 0] == board.AllCells[r, 1] &&
                        board.AllCells[r, 1] == board.AllCells[r, 2])
                    {
                        isWin = true; ;
                    }
                }
            
            for (int c=0; c<3; c++)
            {
                if (board.AllCells[0, c] != CellValue.E &&
                   board.AllCells[0, c] == board.AllCells[1, c] &&
                   board.AllCells[1, c] == board.AllCells[2, c])
                {
                    isWin = true;
                }
            }
            return isWin;
        }
    }
}
