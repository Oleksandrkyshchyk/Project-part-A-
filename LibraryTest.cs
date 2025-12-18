using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project__part_A_;

namespace Project__part_A_Tests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void AddGame_ShouldIncreasePurchasedGamesCount()
        {
            // Arrange
            var library = new Library("MySteam");
            var game = new Game { Title = "Witcher 3" };

            // Act
            library.AddGame(game);

            // Assert
            Assert.AreEqual(1, library.PurchasedGames.Count);
        }

        [TestMethod]
        public void LibraryConstructor_ShouldInitializeAccount()
        {
            // Arrange & Act
            var library = new Library("Player1");

            // Assert
            Assert.IsNotNull(library.UserAccount);
        }

        [TestMethod]
        public void GetTotalGamesCount_ShouldReturnCorrectNumber()
        {
            // Arrange
            var library = new Library("Vault");

            // Act
            int count = library.GetTotalGamesCount();

            // Assert
            Assert.AreEqual(0, count);
        }
    }
}