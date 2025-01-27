// See https://aka.ms/new-console-template for more information

using Mission4;

Console.WriteLine("Hello, World!");
TicTacToeTools t4 = new TicTacToeTools();
char[,] board = new char[3, 3];
t4.PrintBoard(board);