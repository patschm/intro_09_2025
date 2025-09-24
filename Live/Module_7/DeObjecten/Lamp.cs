
namespace DeObjecten;


abstract class Lamp
{
    public ConsoleColor Color { get; set; }
    // protected wil zeggen dat de classe zelf en zijn afgeleide classen erbij kunnen.
    // Maar buiten de familie niet!
    protected int intensiteit = 200;
    // Met virtual geef ik aan dat dit gedrag polymorf-ready is.
    // Een afgeleide class HOEFT NIET te overriden. Het is optioneel
    public virtual void Aan()
    {
        Console.BackgroundColor = Color;
        Console.WriteLine($"Het lampje brandt met {intensiteit}lm");
    }

    // Een afgeleide clas MOET overriden. Wordt wel de hele claass abstract
    public abstract void Uit();
    //{
    //    Console.ResetColor();
    //    Console.WriteLine("Het lampje is uit");
    //}
}

