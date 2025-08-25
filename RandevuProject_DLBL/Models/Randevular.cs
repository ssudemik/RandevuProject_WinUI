using System;
using System.Collections.Generic;

namespace RandevuProject_DLBL.Models;

public partial class Randevular
{
    public int Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid PatientId { get; set; } 

    public Guid DoctorId { get; set; } 

    public byte AppointmentTypeId { get; set; }

    public DateTime AppointmentStartDate { get; set; }

    public string StartHour { get; set; } = null!;

    public DateTime AppointmentEndDate { get; set; }

    public string EndHour { get; set; } = null!;

    public bool IsPatientCome { get; set; }

    public bool IsCancelled { get; set; }

    public string? CancellReason { get; set; }

    public virtual RandevuTipleri AppointmentType { get; set; } = null!;

    public virtual Kisiler Doctor { get; set; } = null!;

    public virtual Kisiler Patient { get; set; } = null!;
}
