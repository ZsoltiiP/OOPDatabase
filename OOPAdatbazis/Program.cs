using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();

            Console.Write("Kérem az felhasználó nevét: ");
            string userName = Console.ReadLine();
            
            Console.Write("Kérem az felhasználó jelszavát: ");
            string userPass = Console.ReadLine();

            Connect c = new Connect(dbName, userName, userPass);
        }
    }
}
