﻿int counter = 0;
bool winner = true;
string[] board = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };
string X = "X";
string O = "O";
bool correctNumber = true;
void Table (string[] board)
{
    Console.WriteLine("________________     ________________");
    Console.WriteLine($"| {board[1]}  | {board[2]}  | {board[3]}  |     | 1  | 2  | 3  |");
    Console.WriteLine("|____|____|____|     |____|____|____|");
    Console.WriteLine($"| {board[4]}  | {board[5]}  | {board[6]}  |     | 4  | 5  | 6  |");
    Console.WriteLine("|____|____|____|     |____|____|____|");
    Console.WriteLine($"| {board[7]}  | {board[8]}  | {board[9]}  |     | 7  | 8  | 9  |");
    Console.WriteLine("|____|____|____|     |____|____|____|");
};
for (int i = 0; i < 9; i++)
{
    string turn = counter % 2 == 0 ? $"{X}" : $"{O}";
    string finalTurn = counter % 2 != 0 ? $"{X}" : $"{O}";
    if (board[1] == board[2] && board[2] == board[3] && board[3] != board[0] || board[4] == board[5] && board[5] == board[6] && board[6] != board[0] || board[7] == board[8] && board[8] == board[9] && board[9] != board[0] ||
        board[1] == board[4] && board[4] == board[7] && board[7] != board[0] || board[2] == board[5] && board[5] == board[8] && board[8] != board[0] || board[3] == board[6] && board[6] == board[9] && board[9] != board[0] ||
        board[1] == board[5] && board[5] == board[9] && board[9] != board[0] || board[3] == board[5] && board[5] == board[7] && board[7] != board[0])
    {
        Console.WriteLine("Wygrywa gracz < " + finalTurn + " >");
        winner = false;
        break;
    }
    int userInput;
    do
    {
        Table(board);
        correctNumber = true;
        userInput = int.Parse(Console.ReadLine());
        if (userInput > 9 || userInput <= 0 || board[userInput] != " ")
        {
            Console.Clear();
            correctNumber = false;
            Console.WriteLine("Chujowa wartość, podaj jeszcze raz.");
            
        }
    } while (!correctNumber);
        board[userInput] = turn;
        counter++;
     Console.Clear();       
}
        while (winner) 
        {   
            Console.WriteLine("REMIS");
            break;
        }
        Table(board);