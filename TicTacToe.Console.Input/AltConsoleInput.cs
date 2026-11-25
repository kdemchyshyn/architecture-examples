namespace Examples.TicTacToe.Consoled;

public class AltConsoleInput
{
    public void StartProcessing(TicTacToeWithEvents game)
    {
        string command = null;
        Console.Out.WriteLine("Welcome to greatest Tic Tac Toe game! Type START to play ");
        while (true)
        {
            command = ReadLine.Read("> ");
            var splitCommand = command.Split(new char[0]);
            switch (splitCommand[0].ToLower())
            {
                case "start":
                    game.StartGame();
                    break;
                case "exit":
                    break;
                case "move":
                    var n = int.Parse(splitCommand[1]);
                    int x = (n - 1) / 3;
                    int y = (n - 1) % 3;
                    game.MakeMove(x, y);
                    break;
            }
                
        }
    }
}