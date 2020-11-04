using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace classerogArvTest
{
    class Strek
    {
        public string Symbol;

        public Strek(string symbol)
        {
            Symbol = symbol;
        }

        public void draw()
        {
            Console.WriteLine("This is you symbol "+Symbol);
        }
    }
}
