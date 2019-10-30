using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class Drzewo
    {
        public Wezel korzen;
        public int Length;
        public int glebokosc;

        public Drzewo(int wartosc)
        {
            this.korzen = new Wezel(wartosc);
            this.korzen.wartosc = wartosc;
            this.Length = 1;
            this.glebokosc = 0;
        }
        public Wezel ZnajdzRodzica(int numer)
        {
            List<int> droga = new List<int>();
            while (numer > 0)
            {
                numer = numer / 2;
                droga.Add(numer);
            }
            droga.Reverse();

            var rodzic = this.korzen;

            for (int i = 1; i < droga.Count; i++)
            {
                if (droga[i] % 2 == 1)
                {
                    rodzic = rodzic.lewe;
                }
                else
                {
                    rodzic = rodzic.prawe;
                }
            }
            return rodzic;
        }

        public void Push(int wartosc)
        {
            var dziecko = new Wezel(wartosc);
            var rodzic = this.ZnajdzRodzica(this.Length);
            dziecko.rodzic = rodzic;
            if(this.Length%2==1)
            {
                rodzic.lewe = dziecko;
            }
            else
            {
                rodzic.prawe = dziecko;
            }
            this.Length++;
            //glebokosc zrobic i popa(zabrac dziecko)
        }
    }
}
