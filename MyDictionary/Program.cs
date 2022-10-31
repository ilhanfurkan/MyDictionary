namespace GenericDictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyDictionary<int, string> players = new MyDictionary<int, string>();
            players.Add(1, "Volkan Demirel");
            players.Add(2, "Diego Lugano");
            players.Add(3, "Roberto Carlos");
            players.Add(4, "Simon Kjaer");
            players.Add(5, "Emre Belözoğlu");
            //players.Add(2, "Babür Kalibre");
            //players.Remove(0);
            Console.WriteLine(players.Count);
            players.PrintD(players);
        }

    }

}