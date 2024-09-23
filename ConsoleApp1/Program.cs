using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character()
            {
                Name = "Titus",
                MaxHitPoints = 100,
                BaseDamage = 10,
                BaseArmor = 10,
                CurrentHitPoints = 100 
            };

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nElige una opción:");
                Console.WriteLine("1. Equipar un equipo");
                Console.WriteLine("2. Atacar");
                Console.WriteLine("3. Curarse");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        EquiparItem(character);
                        break;
                    case "2":
                        Attack(character);
                        break;
                    case "3":
                        Heal(character);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }

        static void EquiparItem(Character character)
        {
            Console.WriteLine("\nElige un equipo para equipar:");
            Console.WriteLine("1. Hacha");
            Console.WriteLine("2. Espada");
            Console.WriteLine("3. Escudo");
            Console.WriteLine("4. Casco");
            Console.Write("Opción: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Weapon axe = new Axe("Battle Axe", 15);
                    axe.Apply(character);
                    Console.WriteLine("Has equipado un Hacha.");
                    break;
                case "2":
                    Weapon sword = new Sword("Katana", 20);
                    sword.Apply(character);
                    Console.WriteLine("Has equipado una Espada.");
                    break;
                case "3":
                    Protection shield = new Shield("Escudo de metal", 10);
                    shield.Apply(character);
                    Console.WriteLine("Has equipado un Escudo.");
                    break;
                case "4":
                    Helmet helmet = new Helmet("Casco de metal", 5);
                    helmet.Apply(character);
                    Console.WriteLine("Has equipado un Casco.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }

            Estadisticas(character);
        }

        static void Attack(Character character)
        {
            Console.WriteLine("\nSimulando un ataque...");
            int dañoInfligido = character.Attack(0);
            Console.WriteLine($"Daño causado: {dañoInfligido}");

            // Simulando ataque
            character.ReceiveDamage(dañoInfligido);
            Console.WriteLine($"Puntos de vida actuales después de recibir daño: {character.CurrentHitPoints}");
        }

        static void Heal(Character character)
        {
            Console.WriteLine("\nCurándote...");
            character.Heal(20);
            Console.WriteLine("Te has curado 20 puntos de vida.");
            Estadisticas(character);
        }

        static void Estadisticas(Character character)
        {
            Console.WriteLine($"\nEstadísticas del personaje:");
            Console.WriteLine($"Nombre: {character.Name}");
            Console.WriteLine($"Puntos de vida máximos: {character.MaxHitPoints}");
            Console.WriteLine($"Puntos de vida actuales: {character.CurrentHitPoints}");
            Console.WriteLine($"Daño base: {character.BaseDamage}");
            Console.WriteLine($"Armadura base: {character.BaseArmor}");
        }
    }
}
