using OOPDatabase;
using System;

namespace OOPDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();

            Console.Write("Kérem a felhasználó nevét: ");
            string userName = Console.ReadLine();

            Console.Write("Kérem a felhasználó jelszavát: ");
            string userPass = Console.ReadLine();

            Connect c = new Connect(dbName, userName, userPass);
        }
    }
}