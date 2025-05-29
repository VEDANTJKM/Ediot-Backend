using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Application
{
    public int Id { get; set; }

    public byte[]? Photo { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Father { get; set; }

    public DateOnly? Dateofbirth { get; set; }

    public int? Age { get; set; }

    public string? Sex { get; set; }

    public string? Maritalstatus { get; set; }

    public int? Children { get; set; }

    public string? Addressline1 { get; set; }

    public string? Addressline2 { get; set; }

    public string? City { get; set; }

    public string? Taluka { get; set; }

    public string? Dist { get; set; }

    public string? Pincode { get; set; }

    public string? Telephone { get; set; }

    public string? Mobile { get; set; }

    public string? Paddressline1 { get; set; }

    public string? Paddressline2 { get; set; }

    public string? Pcity { get; set; }

    public string? Ptaluka { get; set; }

    public string? Pdist { get; set; }

    public string? Ppincode { get; set; }

    public string? Ptelephone { get; set; }

    public string? Pmobile { get; set; }

    public string? Email { get; set; }

    public string? Relativeyesno { get; set; }

    public string? Relativename { get; set; }

    public string? Relation { get; set; }

    public string? Adharcard { get; set; }

    public string? Pancard { get; set; }

    public string? Electioncard { get; set; }

    public string? Drivinglicense { get; set; }

    public string? Disabilityyesno { get; set; }

    public string? Disability { get; set; }

    public string? Refname { get; set; }

    public string? Refbusiness { get; set; }

    public string? Refaddress { get; set; }

    public string? Refcontact { get; set; }

    public DateOnly? Applydate { get; set; }

    public byte[]? Sign { get; set; }

    public int? EducationId { get; set; }
}
