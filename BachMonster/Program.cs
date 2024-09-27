Monster carti = new();
Hero ecco = new ();
    


Console.WriteLine($"{carti.name} has {carti.Hp}Hp");
Console.WriteLine($"{ecco.name} has {ecco.Hp}Hp");


Console.WriteLine("Attack!");
carti.hp -= 10;

Console.WriteLine($"{carti.name} now has {carti.hp} health");

Console.WriteLine("Press any key to continue");
Console.ReadKey();