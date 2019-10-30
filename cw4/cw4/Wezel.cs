using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    class Wezel
    {
        public Wezel rodzic;
        public Wezel lewe;
        public Wezel prawe;
        public int wartosc;

        public Wezel(int wartosc)
        {
            this.wartosc = wartosc;
        }

       
    }
}
