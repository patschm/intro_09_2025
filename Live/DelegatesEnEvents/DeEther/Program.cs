namespace DeEther;

internal class Program
{
    static void Main(string[] args)
    {
        RadioStation r538 = new RadioStation();
        
        r538.Subscribers += Methodes.ViaPostduif;
        r538.Subscribers += Methodes.ViaMail;
        r538.Subscribers += Methodes.ViaSMS;
        r538.Subscribers += Methodes.ViaEther;
        r538.Subscribers += Methodes.ViaPostduif;
        r538.Subscribers += Methodes.ViaRooksignalen;
        r538.Subscribers += Methodes.ViaSMS;
        r538.Subscribers += Methodes.ViaEther;
        r538.Subscribers += Methodes.ViaPostduif;
        r538.Subscribers += Methodes.ViaRooksignalen;
        r538.Subscribers += Methodes.ViaSMS;
        r538.Subscribers += Methodes.ViaEther;


       //r538.Subscribers("Hey klojo's");
        r538.Broadcast();




    }
}
