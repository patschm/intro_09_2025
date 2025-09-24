using System.Diagnostics;

namespace RekenMachine;

internal class Calculator
{
    public int TelOp(int x, int y)
    {
        return x + y;

    }
    public int TelDoor(int x, int y)
    {
        throw new DomeinException { A = x, B= y };
    }
    public double DeelDoor(int x, int y)
    {
        try
        {
            return x / y;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            throw;
        }
    }
}
