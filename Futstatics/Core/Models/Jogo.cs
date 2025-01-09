using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class Jogo
{
    public int Id { get; set; }

    public string TimeMandante { get; set; } = null!;

    public byte PlacarMandante { get; set; }

    public string TimeVisitante { get; set; } = null!;

    public byte PlacarVisitante { get; set; }

    public string Competicao { get; set; } = null!;

    public int Ano { get; set; }
}
