using ConsoleApp2.Ejercicio;
using Ejercicio;

// manual tests

var character = new Character("Juan");
var axe = new Axe();
var sword = new Sword();
var helmet = new Helmet(18);
var shield = new Shield();
character.AddItem(axe);
character.AddItem(sword);
character.AddItem(helmet);
character.AddItem(shield);

Console.WriteLine("Manual tests: ");

Console.WriteLine(character);

character.RemoveItem(sword);
character.RemoveItem(shield);
Console.WriteLine(character);

character.ReceiveDamage(5);
Console.WriteLine(character);

character.Heal(10);
Console.WriteLine(character);