using ConsoleApp2.Ejercicio;
using Ejercicio;

// manual tests

var character = new Character("Juan");
var axe = new Axe();
var sword = new Sword();
var helmet = new Helmet(18);
var shield = new Shield();
var minion = new MinionItem("Lobo", 5, 6);
character.AddItem(axe);
character.AddItem(sword);
character.AddItem(helmet);
character.AddItem(shield);
character.AddItem(minion);

Console.WriteLine("Manual tests: ");

Console.WriteLine(character);

character.RemoveItem(sword);
character.RemoveItem(shield);
Console.WriteLine(character);

character.ReceiveDamage(5);
Console.WriteLine(character);

character.Heal(10);
Console.WriteLine(character);