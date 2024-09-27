public class Weapon
{
 public string name;
 public int MinDamage;
 public int MaxDamage;

 public void attack()
{
  Console.WriteLine($"Attackerar med {Name}");
  return Random.Shared.Next(MinDamage, MaxDamage); 
}


}
