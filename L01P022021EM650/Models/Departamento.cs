using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P022021EM650.Models;

public partial class Departamento
{
    public int Id { get; set; }
    [Display(Name ="Departamento")]
    public string? Departamento1 { get; set; }
}
