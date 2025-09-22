using MySqlX.XDevAPI.Relational;
using OOPAdatbazis.Services;
using OOPDatabase;
using System;

namespace OOPDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISqlStatements sqlStatements = new TableBooks();

            /*Feladat1
            foreach (var item in sqlStatements.GetAllBooks())
            {
                var book = item.GetType().GetProperties();
                Console.WriteLine($"{book[0].Name} = {book[0].GetValue(item)}, {book[1].Name} = {book[1].GetValue(item)}");
            }*/

            ////Feladat2
            //Console.Write("Kérem a rejord id-t: ");

            //var item = sqlStatements.GetById(int.Parse(Console.ReadLine()));

            //var book = item.GetType().GetProperties();

            //Console.WriteLine($"{book[1].Name} = {book[1].GetValue(item)}");


            ////Feladat3
            //Console.Write("Kérem a könyv címét: ");
            //string cim = Console.ReadLine();
            //Console.Write("Kérem a könyv szerzőjét: ");
            //string szerzo = Console.ReadLine();
            //Console.Write("Kérem a könyv kiadási dátumát: ");
            //string datum = Console.ReadLine();

            //var book = new
            //{
            //    Title = cim,
            //    Author = szerzo,
            //    Release = datum
            //};

            //sqlStatements.AddNewRecord(book);


            ////Feladat4
            //Console.Write("Kérem a törlendő rekord id-ját: ");
            //Console.WriteLine(sqlStatements.DeleteRecord(int.Parse(Console.ReadLine())));


            //Feladat5
            Console.Write("Kérem a könyv id-ját: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Kérem a könyv címét: ");
            string cim = Console.ReadLine();
            Console.Write("Kérem a könyv szerzőjét: ");
            string szerzo = Console.ReadLine();
            Console.Write("Kérem a könyv kiadási dátumát: ");
            string datum = Console.ReadLine();

            var book = new
            {
                Title = cim,
                Author = szerzo,
                Release = datum
            };
            Console.WriteLine(sqlStatements.UpdateRecord(id,book));

        }
    }
}