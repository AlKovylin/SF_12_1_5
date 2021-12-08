using System;
using System.Collections.Generic;
using System.Threading;

namespace SF_12_1_5
{
    class Program
    {
        /// <summary>
        /// Точка входа.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<User> users = new Users().GetListUsers();

            for(int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"Привет, {users[i].Name}!\n");

                if (!users[i].IsPremium)
                    ShowAds();
            }
        }

        /// <summary>
        /// Имитирует показ рекламы.
        /// </summary>
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.\n");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}