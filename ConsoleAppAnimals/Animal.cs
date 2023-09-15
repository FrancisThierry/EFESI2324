using System;
using System.Collections.Generic;

namespace ConsoleAppAnimals;

public partial class Animal
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Species { get; set; }
}
