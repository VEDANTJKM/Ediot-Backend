using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptTrainingTopic
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? TrainingTopic { get; set; }

    public string? Trainer { get; set; }

    public string? Attendies { get; set; }

    public string? Location { get; set; }

    public string? Frequency { get; set; }

    public string? TrainingMaterial { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime? TrainingDate { get; set; }

    public TimeOnly? Hours { get; set; }

    public string? Department { get; set; }
}
