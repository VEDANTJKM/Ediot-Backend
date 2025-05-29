using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EmpTrainingFinalDatabase
{
    public int Id { get; set; }

    public int? CourceId { get; set; }

    public int? EmployeeId { get; set; }

    public string? Empname { get; set; }

    public string? CourseName { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public decimal? Hours { get; set; }

    public int? Mid { get; set; }

    public string? Location { get; set; }

    public string? Author { get; set; }

    public string? Instructor { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Uploaddate { get; set; }

    public string? Active { get; set; }

    public string? Uploadby { get; set; }

    public byte[]? EvoluationRequired { get; set; }

    public DateTime? EvoluationDate { get; set; }

    public string? EvoluationMethod { get; set; }

    public string? EvoluationReq { get; set; }

    public bool? GeneralTraining { get; set; }

    public bool? TechnicalTraining { get; set; }

    public bool? SaferyTraining { get; set; }

    public string? Attachment { get; set; }

    public string? Description { get; set; }

    public string? Attachment1JobDescription { get; set; }

    public string? Attachment2TrainingHardcopy { get; set; }

    public DateTime? DueDate { get; set; }

    public bool? AddedDateAfterDueDate { get; set; }
}
