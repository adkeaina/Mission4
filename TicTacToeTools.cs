namespace Mission4;

public class TicTacToeTools
{

    public void PrintBoard(char[,] board)
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            if (row != 0)
            {
                Console.WriteLine("------------");
            }
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

                if (board[row, col] == '\0')
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
        return 0;
    }
}