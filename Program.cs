// See https://aka.ms/new-console-template for more information

using Mission4;


TicTacToeTools t4 = new TicTacToeTools();

// Initializing gameboard
char[,] GameBoard = new char[3, 3];

// Introduction and instantiating supporting tools
Console.WriteLine("Welcome to Tic Tac Toe.");

char[,] gameBoard =
{
    {'1', '2', '3'},
    {'4', '5', '6'},
    {'7', '8', '9'},
};

int player = 1;
int row;
int col;

while (true)
{

    Console.Write($"Player {player} pick where you want to go (1-9):");
    string input = Console.ReadLine();

    int play = int.Parse(input);

    row = (play - 1) / 3;
    col = (play - 1) % 3;

    // Check if the chosen spot is already taken
    if (gameBoard[row, col] == 'X' || gameBoard[row, col] == 'O')
    {
        Console.WriteLine("Spot already taken. Choose another one.");
    }

    if (player == 1)
    {
        gameBoard[row, col] = 'X';
    }
    else
    {
        gameBoard[row, col] = 'O';
    }

    if (player == 1)
    {
        player = 2;
    }
    else
    {
        player = 1;
    }
}
// print board method
t4.PrintBoard(GameBoard);