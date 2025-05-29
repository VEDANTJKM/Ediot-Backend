using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class InterviewFamilyBackground
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int? PersonalId { get; set; }

    public string? Relation { get; set; }

    public string? RelationName { get; set; }

    public string? PresentLastOccupation { get; set; }

    public string? NameOfOrganization { get; set; }
}
