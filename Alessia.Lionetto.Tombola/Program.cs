// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Benvenuto a Tombola");
do
{
    int[] sceltanum=Alessia.Lionetto.Tombola.Manager.sceltaNumeri();
    Alessia.Lionetto.Tombola.Manager.Print("questi sono i numeri scelti da te: ",sceltanum);
    string scelta = Alessia.Lionetto.Tombola.Manager.sceltaDifficoltà();
    int[] numeriEstratti=Alessia.Lionetto.Tombola.Manager.estrazioneNumeri();
    Alessia.Lionetto.Tombola.Manager.Print("questi sono i numeri estratti: ", numeriEstratti);
    Alessia.Lionetto.Tombola.Manager.CheckWin(sceltanum, numeriEstratti);
    Console.WriteLine("Vuoi fare un'altra partita? Premi 'Q' per uscire oppure qualunque altro per continuare a giocare");
}
while (Console.ReadKey().KeyChar != 'Q');
