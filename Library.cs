using System;
using System.Collections.Generic;

namespace Project__part_A_
{
    public class Library
    {
        // Поля / Властивості
        public string OwnerName { get; set; }
        
        // Агрегація: список ігор, які можуть існувати незалежно від бібліотеки
        public List<Game> PurchasedGames { get; set; } 

        // Композиція: акаунт, який належить тільки цій бібліотеці
        public Account UserAccount { get; private set; }

        // Конструктор
        public Library(string ownerName)
        {
            this.OwnerName = ownerName;

            // РЕАЛІЗАЦІЯ АГРЕГАЦІЇ: список ініціалізується, але об'єкти Game додаються ззовні
            this.PurchasedGames = new List<Game>();

            // РЕАЛІЗАЦІЯ КОМПОЗИЦІЇ: об'єкт Account створюється прямо тут
            this.UserAccount = new Account(); 
        }

        // Методи із заглушками
        public void AddGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void LaunchGame(string title)
        {
            throw new NotImplementedException();
        }

        public int GetTotalGamesCount()
        {
            throw new NotImplementedException();
        }
    }
}