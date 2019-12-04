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

        List<Node> odwiedzone;

        void DFS(Node n)
        {
            if (this.odwiedzone.Contains(n))
                return;
            this.odwiedzone.Add(n);
            var krawedzie = this.ZnajdzKrawedzie(n);
            foreach (var k in odwiedzone)
                {
                    var drugi = krawedzie.WeźDrugi(n);
                    DFS(drugi);
                }
        }

        List<Krawędź>ZnajdzKrawedzie(Node n)
        {
            List<Krawędź> wynik = new List<Krawędź>();
            foreach(var k in this.krawedzie)
            {
                if(k.start==n || k.koniec==n)
                {
                    wynik.Add(k);
                }
            }
            return wynik;
        }

        /*2 sposób na to co wyżej
        List<Krawędź>znajdzkrawedzie(Node n)
        {
            return this.krawedzie.Where(k=>k.start==n || k.koniec==n).ToList()
        }
        */

        public void PrzechodzenieDFS(Node start)
        {
            this.odwiedzone = new List<Node>();
            this.DFS(start);
            //wypisać kolejne Node'y
        }

        List<Node> kolejka; 

        void BFS(Node n)
        {
            if (this.odwiedzone.Contains(n))
                return;
            else
            this.kolejka.Add(n);
            var ZnajdzKrawedzie = ;
            kolejka.ZnajdźDrugi(n);
        }

        List<Node> ZnajdzSasiada(Node n)
        {
            List<Node> wynik = new List<Node>();
            foreach(var k in this.sasiad)
            {
                if(k.start==n)
                {
                    wynik.Add(k.koniec);
                }
                else if (k.koniec == n)
                {
                    wynik.Add(k.start);
                }
            }
            return wynik;
        }

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
        public Krawędź(Node s, Node k, int w = 1)
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

            if (this.start == n)
            {
                return this.koniec;

            }
            else
                return this.start;
        }

    }

}
