namespace Mission4;

public class TicTacToeTools
{

    // prints the tic-tac-toe board
    public void PrintBoard(char[,] board)
    {
        //prints each row
        for (int row = 0; row < board.GetLength(0); row++)
        {
            if (row != 0)
            {
                Console.WriteLine("------------");
            }
            // prints each value
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (col != 0)
                {
                     Console.Write($" | ");
                }
                else
                {
                    Console.Write(" ");
                }
                if (board[row, col] == '\0') // in case something goes wrong and the board ends up as blank
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write($"{board[row, col]} ");
                }
            }
            Console.WriteLine();
        }
    }

    public int IsWinner(char[,] board)
    {
        // check rows for winner
        for (int row = 0; row < board.GetLength(0); row++)
        {
            int xCount = 0;
            int oCount = 0;
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (board[row, col] == 'X') xCount++;
                else if (board[row, col] == 'O') oCount++;
            }

            if (xCount == 3) return 1;
            else if (oCount == 3) return 2;
        }
        
        //check cols for winner
        for (int col = 0; col < board.GetLength(1); col++)
        {
            int xCount = 0;
            int oCount = 0;
            for (int row = 0; row < board.GetLength(0); row++)
            {
                if (board[row, col] == 'X') xCount++;
                else if (board[row, col] == 'O') oCount++;
            }
            if (xCount == 3) return 1;
            else if (oCount == 3) return 2;
        }
        
        // check diagonals for winner
        if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
        {
            if (board[1,1] == 'X') return 1;
            else if (board[1,1] == 'O') return 2;
        }
        
        // to check the game isn't over yet
        foreach (char c in board)
        {
            if (char.IsDigit(c))
                return 0;
        }
        
        // if it's a cats game
        return -1;
    }
}