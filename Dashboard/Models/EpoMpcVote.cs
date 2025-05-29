using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpoMpcVote
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Epo { get; set; }

    public string? Mpc1Vote { get; set; }

    public string? Mpc2Vote { get; set; }

    public string? Mpc3Vote { get; set; }

    public string? Mpc4Vote { get; set; }

    public string? Mpc5Vote { get; set; }

    public string? Mpc6Vote { get; set; }

    public int? Countvote { get; set; }

    public string? Status { get; set; }

    public string? NeedHigherAuthority { get; set; }

    public string? HigherAuthorityVote { get; set; }

    public DateTime? Mpc1VoteDate { get; set; }

    public DateTime? Mpc2VoteDate { get; set; }

    public DateTime? Mpc3VoteDate { get; set; }

    public DateTime? Mpc4VoteDate { get; set; }

    public DateTime? Mpc5VoteDate { get; set; }

    public DateTime? Mpc6VoteDate { get; set; }

    public DateTime? HigherAuthorityVoteDate { get; set; }
}
