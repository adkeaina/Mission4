// See https://aka.ms/new-console-template for more information

using Mission4;


TicTacToeTools t4 = new TicTacToeTools();


// Introduction and instantiating supporting tools
Console.WriteLine("Welcome to Tic Tac Toe.");

// initialize gameboard
char[,] gameBoard =
{
    {'1', '2', '3'},
    {'4', '5', '6'},
    {'7', '8', '9'},
};

// initialize gameboard
int player = 1;
int row;
int col;
bool endgame = true;
bool playagain = true;
string response = "";
// while endgame is true, the game plays
do
{
    while (endgame)
    {
        t4.PrintBoard(gameBoard);
        // 
        Console.Write($"Player {player} pick where you want to go (1-9):");
        string input = Console.ReadLine();

        int play = int.Parse(input);

        row = (play - 1) / 3;
        col = (play - 1) % 3;
        // Check if the chosen spot is already taken
        if (gameBoard[row, col] == 'X' || gameBoard[row, col] == 'O')
        {
            Console.WriteLine("Spot already taken. Choose another one.");
            continue;
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
        int winner = t4.IsWinner(gameBoard);
        if (winner == 1)
        {
            Console.WriteLine("Player 1 won!");
            endgame = false;
        }
        else if (winner == 2)
        {
            Console.WriteLine("Player 2 won!");
            endgame = false;
        }
        else if (winner == -1)
        {
            Console.WriteLine("CATS GAME!");
            endgame = false;
        }
        else { continue; }

    }

    Console.WriteLine("Do you want to play again? (Yes/No)");
    response = Console.ReadLine();
    response = response.ToLower();
    if (response == "no")
    {
        playagain = false;
    }
    else if (response == "yes")
    {

        // initialize gameboard
        gameBoard = new char[,]
    {
        {'1', '2', '3'},
        {'4', '5', '6'},
        {'7', '8', '9'},
    };

        // initialize gameboard
        player = 1;
        row = 0 ;
        col = 0 ;
        endgame = true;
        playagain = true;
        response = "";

    }
    else
    {
        Console.WriteLine("Please enter a valid response (Yes/No)");
    }
    
} while (playagain);
    
