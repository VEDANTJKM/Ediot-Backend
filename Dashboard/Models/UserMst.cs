using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class UserMst
{
    public int TenentId { get; set; }

    public int UserId { get; set; }

    public int LocationId { get; set; }

    public int CrupId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? FirstName1 { get; set; }

    public string? LastName1 { get; set; }

    public string? FirstName2 { get; set; }

    public string? LastName2 { get; set; }

    public string LoginId { get; set; } = null!;

    public string? Password { get; set; }

    public int? UserType { get; set; }

    public string? Remarks { get; set; }

    public string ActiveFlag { get; set; } = null!;

    public DateTime? LastLoginDt { get; set; }

    public int? UserDetailId { get; set; }

    public string? AccLock { get; set; }

    public string? FirstTime { get; set; }

    public string? PasswordChng { get; set; }

    public string? ThemeName { get; set; }

    public DateTime? ApprovalDt { get; set; }

    public string? VerificationCd { get; set; }

    public string? EmailAddress { get; set; }

    /// <summary>
    /// Ayo Till date
    /// </summary>
    public DateTime? TillDt { get; set; }

    public bool? IsSignature { get; set; }

    public string? SignatureImage { get; set; }

    public string? Avtar { get; set; }

    public int? CompId { get; set; }

    public int? EmpId { get; set; }

    public bool? CheckinSwitch { get; set; }

    public long? LoginActive { get; set; }

    public bool? Activeuser { get; set; }

    public DateOnly? Userdate { get; set; }

    public string? Language1 { get; set; }

    public string? Language2 { get; set; }

    public string? Language3 { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? EmployeePosition { get; set; }

    public string? Salary { get; set; }

    public DateTime? DateOfJoining { get; set; }

    public string? PhoneNo { get; set; }

    public string? Pincode { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Img { get; set; }

    public int? PersonId { get; set; }

    public string? LibraryMenu { get; set; }

    public string? LibraryReader { get; set; }

    public string? LibraryMenuDept { get; set; }

    public string? TicketUser { get; set; }

    public string? EventApprovalUser { get; set; }

    public bool? AdminRights { get; set; }

    public bool? SecondaryApprovalRequired { get; set; }

    public string? SecondaryApprovalPerson { get; set; }

    public string? Company { get; set; }

    public int? MsproUserType { get; set; }

    public int? ToolTrialUserType { get; set; }
}
