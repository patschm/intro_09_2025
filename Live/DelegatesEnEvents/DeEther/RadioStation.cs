
namespace DeEther;

delegate void OntvangstMethode(string bericht);

internal class RadioStation
{

    public event OntvangstMethode Subscribers;

    public void Broadcast()
    {
        string boodschap = "Hallo luisteraars";
        if (Subscribers != null) 
        { 
            Subscribers(boodschap);
        }
    }
}
