using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P022021EM650.Models;

public partial class Materia
{
    public int Id { get; set; }
    [Display(Name ="Materia")]
    public string? Materia1 { get; set; }
    [Display(Name = "U.V")]
    public int? UnidadesValorativas { get; set; }

    public string? Estado { get; set; }
}
