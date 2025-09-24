using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma
{
    public class Rechthoek : Figuur
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public override void Teken(Graphics g)
        {
            g.DrawRectangle(new Pen(Kleur, 4), Positie.X, Positie.Y, Breedte, Hoogte);
        }
    }
}
