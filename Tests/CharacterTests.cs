using Xunit;
using ConsoleApp2.Ejercicio;

namespace ConsoleApp2.Tests
{
    public class CharacterTests
    {
        [Fact]
        public void Character_CanAddItem()
        {
            // Arrange
            var character = new Character("Juan");
            var axe = new Axe();

            // Act
            character.AddItem(axe);

            // Assert
            Assert.Equal(1, character.InventoryCount());
        }

        [Fact]
        public void Character_CanRemoveItem()
        {
            // Arrange
            var character = new Character("Juan");
            var axe = new Axe();
            character.AddItem(axe);

            // Act
            character.RemoveItem(axe);

            // Assert
            Assert.Equal(0, character.InventoryCount());
        }

        [Fact]
        public void Character_InitialHitPointsAreMax()
        {
            // Arrange
            var character = new Character("Juan");

            // Act
            var hitPoints = character.HitPoints;

            // Assert
            Assert.Equal(Character.DefaultMaxHp, hitPoints);
        }

        [Fact]
        public void Character_ReceiveDamageReducesHitPoints()
        {
            // Arrange
            var character = new Character("Juan");
            int damage = 5;

            // Act
            character.ReceiveDamage(damage);

            // Assert
            Assert.Equal(Character.DefaultMaxHp - damage, character.HitPoints);
        }

        [Fact]
        public void Character_HealDoesNotExceedMaxHitPoints()
        {
            // Arrange
            var character = new Character("Juan");
            character.ReceiveDamage(5);

            // Act
            character.Heal(10);

            // Assert
            Assert.Equal(Character.DefaultMaxHp, character.HitPoints);
        }

        [Fact]
        public void MinionItem_AddsMinionToCharacter()
        {
            // Arrange
            var character = new Character("Juan");
            var wolfMinionItem = new MinionItem("Wolf", 5, 2); // Genera un lobo

            // Act
            character.AddItem(wolfMinionItem);
            wolfMinionItem.Apply(character);

            // Assert
            Assert.Contains("Wolf", character.ToString());
        }

        [Fact]
        public void Character_AttackIncludesMinionDamage()
        {
            // Arrange
            var character = new Character("Juan");
            var wolfMinionItem = new MinionItem("Wolf", 5, 2); // Genera un lobo con 2 de daño
            wolfMinionItem.Apply(character);

            // Act
            int totalAttack = character.Attack();

            // Assert
            Assert.Equal(character.BaseDamage + 2, totalAttack); // BaseDamage es 1, Minion Damage es 2
        }

        [Fact]
        public void Character_InventoryCanApplyMultipleMinions()
        {
            // Arrange
            var character = new Character("Juan");
            var wolfMinionItem = new MinionItem("Wolf", 5, 2);
            var dragonMinionItem = new MinionItem("Dragon", 20, 10); // Genera un dragón con 10 de daño

            // Act
            wolfMinionItem.Apply(character);
            dragonMinionItem.Apply(character);
            int totalAttack = character.Attack();

            // Assert
            Assert.Equal(character.BaseDamage + 2 + 10, totalAttack); // BaseDamage es 1, Lobo 2 y Dragón 10
        }
    }
}
