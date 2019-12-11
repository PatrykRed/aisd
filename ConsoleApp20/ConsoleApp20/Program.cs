using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    //Dijkstry
    class Krawedz
    {
        Node start;
        Node koniec;
        int waga;

        public Krawedz(Node s, Node k, int w)
        {
            this.start = s;
            this.koniec = k;
            this.waga = w;
        }
    }
    class Node
    {
        int wartosc;
        public Node(int w)
        {
            this.wartosc = w;
        }
    }
    class Para
    {
        public Node prev;
        public int odleglosc;
        public Para(Node prev, int odleglosc)
        {
            this.prev = prev;
            this.odleglosc = odleglosc;
        }
    }
    class Graf
    {
        Dictionary<Node, Para> tabelka = new Dictionary<Node, Para>();
        while(true)
        {
            var element = tabelka.OrderBy(x => x.Value.odleglosc).FirstOrDefault(x => !this.odwiedzone(x.key));
            if(element.key==null)
                break;
            if(element.key!=null)

            (element.key, element.Value.odleglosc)
        }
      
    if(tabelka.ContainsKey)
        {
        tabelka[drugi].odleglosc

    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
