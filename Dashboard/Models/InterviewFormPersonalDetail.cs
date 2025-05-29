using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class InterviewFormPersonalDetail
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? FatherHusbandName { get; set; }

    public DateOnly? Dob { get; set; }

    public decimal? Age { get; set; }

    public string? Sex { get; set; }

    public string? MaritualStatus { get; set; }

    public int? NoOfChildren { get; set; }

    public string? CurrentAddline1 { get; set; }

    public string? CurrentAddline2 { get; set; }

    public string? CurrentAddcity { get; set; }

    public string? CurrentAddtaluka { get; set; }

    public string? CurrentAdddist { get; set; }

    public string? CurrentAddmobile { get; set; }

    public string? PerAddline1 { get; set; }

    public string? PerAddline2 { get; set; }

    public string? PerAddcity { get; set; }

    public string? PerAddtaluka { get; set; }

    public string? PerAdddist { get; set; }

    public string? PerAddmobile { get; set; }

    public string? PerAddemail { get; set; }

    public bool? RelativesAtSswhite { get; set; }

    public string? RelativeName { get; set; }

    public string? RelativeRelation { get; set; }

    public string? IdentityProof { get; set; }

    public string? IdentityProofName { get; set; }

    public bool? Disability { get; set; }

    public string? DisabilityName { get; set; }

    public DateTime? UploadDate { get; set; }

    public int? BasicQuestionScore { get; set; }

    public int? GrammarScore { get; set; }

    public int? LogicalScore { get; set; }

    public string? Experience { get; set; }

    public string? Reference { get; set; }

    public string? InterviewPdf { get; set; }

    public string? PersonImg { get; set; }
}
