using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationBonou
{
    public int Id { get; set; }

    public int? RuleId { get; set; }

    public int? ProgrammerId { get; set; }

    public int? UserId { get; set; }

    public int? SettingtimeBonous { get; set; }

    public int? CalSettingtimeBonous { get; set; }

    public int? SettingtimeRating { get; set; }

    public int? CalSettingtimeRating { get; set; }

    public int? ResettingtimeBonous { get; set; }

    public int? CalResettingtimeBonous { get; set; }

    public int? ResettingtimeRating { get; set; }

    public int? CalResettingtimeRating { get; set; }

    public int? TrainninggivenBonous { get; set; }

    public int? CalTrainninggivenBonous { get; set; }

    public int? TrainninggivenRating { get; set; }

    public int? CalTrainninggivenRating { get; set; }

    public int? TrainningtakenBonous { get; set; }

    public int? CalTrainningtakenBonous { get; set; }

    public int? TrainingtakenRating { get; set; }

    public int? CalTrainningtakenRating { get; set; }

    public int? SetupbinBonous { get; set; }

    public int? CalSetupbinBonous { get; set; }

    public int? SetupbinRating { get; set; }

    public int? CalSetupbinRating { get; set; }

    public int? PartcomplexityRating { get; set; }

    public int? PartcomplexityBonous { get; set; }

    public int? DiciplineBonous { get; set; }

    public int? DiciplineRating { get; set; }

    public int? CalDiciplineBonous { get; set; }

    public int? CalDiciplineRating { get; set; }

    public DateTime? BonousMonth { get; set; }

    public DateTime? Timestamp { get; set; }
}
