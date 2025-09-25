using DoomsdayPreppers;
using Gelro;
using Philips;
using Yunex;

namespace MijnErf;

internal class Program
{
    static void Main(string[] args)
    {
        Detectielus lus = new Detectielus();
        Hek hek = new Hek();
        Lamp lamp = new Lamp();
        Valkuil valkuil = new Valkuil();

        lus.Connect(lamp);
        lus.Connect(valkuil);
        lus.Connect(hek);

        // En hier komt het tuig....
        lus.GaatAf(); // Hierachter dus ook niet
        // Hieronder mag geen regel code meer staan
    }
}
