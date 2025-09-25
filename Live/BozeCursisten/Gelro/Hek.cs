﻿using Standards;

namespace Gelro;

public class Hek : IDevice
{
    public void Activate()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Het hek gaat open");
    }
}
