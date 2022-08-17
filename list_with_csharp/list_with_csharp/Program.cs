using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_with_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clients = new List<string>();
            List<int> ages = new List<int>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Informe o nome da posição {i}:");
            //    clients.Add(Console.ReadLine());
            //}

            //foreach(string client in clients)
            //{
            //    Console.WriteLine(client);
            //}

            //clients.RemoveAt(2);
            //clients.RemoveAll(client => client == "Lucas");
            //Console.WriteLine("*********************************************************");

            //foreach (string client in clients)
            //{
            //    Console.WriteLine(client);
            //}
            //Console.ReadLine();
            Console.WriteLine("*********************************************************");
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe um valor:");
                ages.Add(int.Parse(Console.ReadLine()));
            }
            foreach(int age in ages)
            {
                Console.WriteLine(age);
            }
            Console.ReadLine();

            //int search = ages.FindAll(age => age > 2);
            //Console.WriteLine(search);

            List<int> filteredAges = ages.FindAll(age => age > 2);
            Console.WriteLine(filteredAges);
            Console.ReadLine();


        }
    }
}
