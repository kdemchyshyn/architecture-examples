using Examples.TicTacToe;
using Examples.TicTacToe.Consoled;

var  game = new TicTacToeWithEvents(new Player("A"), new Player("B") );
var output = new ConsoleOutput();
var cntoutput = new CellCntView();
output.ListenTo(game);
cntoutput.ListenTo(game);

//var input = new ConsoleInput();
var input = new AltConsoleInput();
input.StartProcessing(game);