

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WatDoenWeErmee
{
    internal class Program
    {
        static TextBox tb;
        static Label lbl;

        static void Main(string[] args)
        {
            Form fq = new Form();
            fq.Text = "ZOMAAR EEN FORM";
            fq.MouseMove += BeweegMuis;

            lbl = new Label();
            lbl.Location = new Point(100, 0);
            lbl.Height = 50;

            fq.Controls.Add(lbl);

            Button btn = new Button();
            btn.Location = new Point(100, 200);
            btn.Text = "Click me!";
            btn.Click += ClikMe;

             tb = new TextBox();
            tb.Location = new Point(100, 100);
            tb.Width = 100;
            fq.Controls.Add(tb);

            fq.Controls.Add(btn);

            fq.ShowDialog();

            Console.ReadLine();
        }

        private static void BeweegMuis(object sender, MouseEventArgs e)
        {
            lbl.Text = $"{e.Location.X}, {e.Location.Y}";
            Console.WriteLine($"{e.Location.X}, {e.Location.Y}" );
        }

        private static void ClikMe(object sender, EventArgs e)
        {
            MessageBox.Show("Weet u het zeker");
            Button btn = sender as Button;
            btn.Parent.BackColor = Color.Red;
            Console.WriteLine(tb.Text);
        }
    }
}
