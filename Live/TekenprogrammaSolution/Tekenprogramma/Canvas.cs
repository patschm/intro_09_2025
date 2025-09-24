namespace Tekenprogramma;

internal class Canvas
{
    private List<Rechthoek> rechthoeken = new List<Rechthoek>();
    private List<Driehoek> driehoeken = new List<Driehoek>();
    private List<Cirkel> cirkels = new List<Cirkel>();

    public void VoegToe(Rechthoek rechthoek)
    {
        rechthoeken.Add(rechthoek);
        Refresh();
    }
    public void VoegToe(Driehoek driehoek)
    {
        driehoeken.Add(driehoek);   
        Refresh();
    }
    public void VoegToe(Cirkel cirkel)
    {
        cirkels.Add(cirkel);    
        Refresh();
    }
    public void Refresh()
    {
        Console.Clear();
        foreach (Driehoek figuur in driehoeken)
        {
            figuur.Teken();
        }
        foreach (Rechthoek figuur in rechthoeken)
        {
            figuur.Teken();
        }
        foreach (Cirkel  figuur in cirkels)
        {
            figuur.Teken();
        }
    }
}
