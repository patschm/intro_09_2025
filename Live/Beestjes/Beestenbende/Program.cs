using Beestenbende.Dieren;
using Beestenbende.Verblijven;

namespace Beestenbende;

internal class Program
{
    static void Main(string[] args)
    {
        Dierentuin zoo = new();

        Aquarium aq = new();
        zoo.Extend( aq );
        aq.Add(new Sidderaal());
        aq.Add(new Clownsvis());
        aq.Add(new Tijger());

        Steppe st = new();
        zoo.Extend(st);
        st.Add(new Wildebeest());
        st.Add(new Zebra());

        Kooi ki = new();
        zoo.Extend( ki );
        ki.Add(new Tijger());
        ki.Add(new Leeuw());
        ki.Add(new Wildebeest());

        Apenrots at = new();
        zoo.Extend(at);
        at.Add(new Gorilla());
        at.Add(new OerangOetang());


        Poel p = new();
        p.Add(new Tijger());
        p.Add(new Nijlpaard());
        zoo.Extend(p);

        zoo.Open();

    }
}
