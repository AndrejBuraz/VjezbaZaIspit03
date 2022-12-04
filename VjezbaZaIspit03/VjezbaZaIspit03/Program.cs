using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspit03
{
    class Neboder
    {
        private int visina, brojKatova;

        public int Visina { get => visina; set => visina = value; }
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }

        public Neboder(int visina, int brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;
        }

        public override string ToString()
        {
            string ispis;
            ispis = ("Neboder ima " + this.BrojKatova + " katova i visok je " + this.Visina + " metara. Prosjecna visina kata je " + (this.Visina / this.brojKatova) + " metara");
            return ispis;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder(200, 100);
            Tower.Visina += 10;
            Tower.BrojKatova ++;
            Console.WriteLine(Tower.ToString());
            Console.ReadKey();
        }
    }
}
