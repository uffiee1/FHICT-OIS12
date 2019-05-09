using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Dagwaarde
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Auto Audi = new Auto("ABC-12-AB",Auto.Brandstofsoort.benzine, random.Next(0, 200000));
            Auto BMW = new Auto("ABD-14-AN", Auto.Brandstofsoort.dizel, random.Next(0, 200000));
            Auto Mercedes = new Auto("ABE-15-AC", Auto.Brandstofsoort.elektrishe, random.Next(0, 200000));
            Auto Volkswagen = new Auto("ABF-16-AY", Auto.Brandstofsoort.lpg, random.Next(0,200000));

            List<Auto> autolijst = new List<Auto>
            {
                Audi,
                BMW,
                Mercedes,
                Volkswagen
            };

            foreach (Auto item in autolijst)
            {
                Console.WriteLine(item.ToString());
            }





             

            Console.ReadKey();
        }




    }
}
