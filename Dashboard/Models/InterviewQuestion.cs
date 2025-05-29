using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class InterviewQuestion
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? QuestionType { get; set; }

    public string? QuestionForBasicEnglish { get; set; }

    public string? QuestionForBasicGrammer { get; set; }

    public string? OptionBasic1 { get; set; }

    public string? OptionBasic2 { get; set; }

    public string? OptionBasic3 { get; set; }

    public string? OptionBasic4 { get; set; }

    public string? QuestionForLogic { get; set; }

    public string? OptionLogic1 { get; set; }

    public string? OptionLogic2 { get; set; }

    public string? OptionLogic3 { get; set; }

    public string? OptionLogic4 { get; set; }

    public string? LogicQuestionImage { get; set; }

    public bool? Haslogicimage { get; set; }

    public string? Answer { get; set; }
}
