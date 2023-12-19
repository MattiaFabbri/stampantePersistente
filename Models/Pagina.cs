using System;

namespace WPFStampante.Models
{
    public class Pagina
    {
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }

        public Pagina(int C, int M, int Y, int B)
        {

            this.C = C;
            this.M = M;
            this.Y = Y;
            this.B = B;

        }
        public Pagina()
        {
            Random rnd = new Random();
            C = rnd.Next(0, 4);
            M = rnd.Next(0, 4);
            Y = rnd.Next(0, 4);
            B = rnd.Next(0, 4);
        }
    }
}
