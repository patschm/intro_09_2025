namespace TheCompagny;

internal class Program
{
    static void Main(string[] args)
    {
        ACME company = new ACME();
        Isabella isabella = new Isabella();
        Jordi jordi = new();
        Dustin dustin = new();
        Bokito bokito = new Bokito();

        company.Hire( jordi);
        company.Hire(dustin);
        company.Hire(isabella);
        company.Hire(bokito);

        company.StartProduction();
    }
}
