using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TicketProcessChat
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string Ticketno { get; set; } = null!;

    public int? TicketUser { get; set; }

    public string? TicketChat { get; set; }

    public string? TicketRemark { get; set; }

    public DateTime? ChatDate { get; set; }
}
