Monster carti = new();
Hero ecco = new ();



Console.WriteLine($"{carti.name} has {carti.Hp}Hp");
Console.WriteLine($"{ecco.name} has {ecco.Hp}Hp");


Console.WriteLine("Attack!");

Monster.hp -= 10;

Console.ReadLine();