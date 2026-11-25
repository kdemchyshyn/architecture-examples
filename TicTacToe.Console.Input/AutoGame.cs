namespace Examples.TicTacToe.Consoled;

using Examples.TicTacToe;

public class AutoGame
{
    public void StartProcessing(TicTacToeWithEvents game)
    {
        game.StartGame();
        
        game.MakeMove(1, 1);
        game.MakeMove(1, 2);
        game.MakeMove(0, 2);
        game.MakeMove(2, 0);
        game.MakeMove(0, 0);
        game.MakeMove(2, 2);
        game.MakeMove(0, 1);
    }
}