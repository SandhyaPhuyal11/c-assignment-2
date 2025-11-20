namespace task4;

public class Player
{
  //Instance fields
  public string playerName;
  public int level;
  public int health;


  //Default constructor
  public Player()
  {
    Console.WriteLine("Default constructor has been called");
    playerName = "Unknown";
    level = 0;
    health = 0;

  }


  //Parameterized constructor
  public Player(string name,int lvl,int hp)
  {
    playerName = name;
    level = lvl;
    health = hp;
  }
}