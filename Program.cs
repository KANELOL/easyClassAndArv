using System;

namespace classerogArvTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var enStrek = new Strek("y");
            var enFirkant = new Firkant();
            enStrek.draw();
            enFirkant.draw();
        }
    }
}
