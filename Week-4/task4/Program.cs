using task4;

class Program
{
  static void Main(string[] args)
  {
    //Object using default constructor
    Player p1 = new Player();
    Console.WriteLine("Player 1 Details:");
    Console.WriteLine($"Name:{p1.playerName},Level: {p1.level},Health:{p1.health}");
    Console.WriteLine();


    //Object using parameterized constructor
    Player p2 = new Player("Sandhya",5,100);
    Console.WriteLine("Player 1 Details:");
    Console.WriteLine("Player 2 Details:");
    Console.WriteLine($"Name: {p2.playerName}, Level:{p2.level}, Health: {p2.health}");


  }
}