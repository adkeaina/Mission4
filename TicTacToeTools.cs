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
}