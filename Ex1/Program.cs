using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ugol ugol = new Ugol(180, 5, 5);
            Console.WriteLine("ugol = {0} gradusov, {1} minut, {2} sekund", ugol.Gradus, ugol.Min, ugol.Sec);
            ugol.ToRadians();
            Console.ReadKey();
        }

        
    }
    class Ugol
    {
        public int Gradus { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }

        public Ugol(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadians()
        {
            Console.WriteLine("Ugol {0} gradusov = {1:F2} radianov", Gradus, (Gradus * Math.PI) / 180);
        }
    }
}
