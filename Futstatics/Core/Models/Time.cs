using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class Time
{
    public int IdTime { get; set; }

    public string Nome { get; set; } = null!;

    public string? Estadio { get; set; }

    public string? Estado { get; set; }

    public string? Cidade { get; set; }

    public string? Foto { get; set; }

    public string? Mascote { get; set; }
}
