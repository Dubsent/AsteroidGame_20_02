using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer("Игрок 1", new DateTime(1987, 6, 16, 3, 15, 35));

            Gamer[] gamers = new Gamer[100];
            for (var i = 0; i < gamers.Length; i++)
            {
                var g = new Gamer(string.Format("Gamer {0}", i + 1), DateTime.Now.Subtract(TimeSpan.FromDays(365 * (i + 18))));
                //g.Name = $"Gamer {i + 1}";
                gamers[i] = g;
            }

            gamer.SayYourName();


            Console.WriteLine();

            foreach (var g in gamers)
            {
                g.SayYourName();
            }

            //gamer.SetName("Dubsent");
            //Console.WriteLine("Имя игрока {0}", gamer.GetName());

            gamer.Name = "BowWow";
            Console.WriteLine("Игрок {0}", gamer.Name);

            Console.ReadLine();


        }
    }
}
