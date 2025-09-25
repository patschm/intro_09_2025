using TekenprogrammaAdvanced;

namespace Tekenprogramma;

internal class Canvas
{
    private List<Figuur> figuren = new List<Figuur>();
    private IDrawable device = new ConsoleDevice(); 
    
    public void VoegToe(Figuur figuur)
    {
        figuren.Add(figuur);
        Refresh();
    }
    public void Refresh()
    {
        Console.Clear();
        foreach (Figuur figuur in figuren)
        {
            figuur.Teken(device);
        }
    }
}
