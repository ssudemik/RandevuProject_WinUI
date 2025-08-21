using System;
using System.Collections.Generic;

namespace RandevuProject_DLBL.Models;

public partial class Roller
{
    public string Id { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string Name { get; set; } = null!;
}
