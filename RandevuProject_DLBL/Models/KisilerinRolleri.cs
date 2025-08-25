using System;
using System.Collections.Generic;

namespace RandevuProject_DLBL.Models;

public partial class KisilerinRolleri
{
    public Guid UserId { get; set; } = Guid.NewGuid();

    public string RoleId { get; set; } = null!;

    public virtual Roller Role { get; set; } = null!;

    public virtual Kisiler User { get; set; } = null!;
}
