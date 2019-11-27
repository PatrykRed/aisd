using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeszukiwanieWGlab
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Node
    {
        public int wartosc;

        public Node(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public override string ToString()
        {
            return this.wartosc.ToString();
        }
        
    }

    class Krawędź
    {
        public Node start;
        public Node koniec;
        public int waga;
        public Krawędź(Node s, Node k, int w=1)
        {
            this.start = s;
            this.koniec = k;
            this.waga = w;
        }
        public override string ToString()
        {
            return $"{this.start}-{this.koniec}({this.waga})";
        }

        public Node ZnajdźDrugi(Node n)
        {
            return this.start == n ? this.koniec : this.start;

            if(this.start==n)
            {
                return this.koniec;
            
            }
            else
                return this.start;
        }
    }

}
