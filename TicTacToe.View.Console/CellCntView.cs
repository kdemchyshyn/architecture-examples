namespace Examples.TicTacToe.Consoled;

using Examples.TicTacToe;

public class CellCntView
{
    private TicTacToeWithEvents game;
    
    // subscribe
    public void ListenTo(TicTacToeWithEvents game)
    {
        this.game = game;
        game.FieldUpdated += OnFieldUpdated;
    }
    
    // cnt
    private Dictionary<string, int> CountCells(Cell[,] field)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("Empty", 0);

        foreach (Cell cell in field)
        {
            if (cell.IsEmpty)
            {
                dict["Empty"] += 1;
                continue;
            }
            
            var player = cell.MarkedByPlayer.Name;
            if (!dict.ContainsKey(player))
            {
                dict.Add(player, 0);
            }
            dict[player] += 1;
        }
        
        return dict;
    }
    
    // show cnt
    private void OnFieldUpdated(Cell[,] field)
    {
        Dictionary<string, int> count = CountCells(field);
        foreach (var kvp in count)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}