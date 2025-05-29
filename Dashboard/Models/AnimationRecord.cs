using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class AnimationRecord
{
    public int Id { get; set; }

    public string? PersonName { get; set; }

    public string? Type { get; set; }

    public string? FormatsForStoryboards { get; set; }

    public string? StoryboardIdeas { get; set; }

    public string? StoryboardWriteup { get; set; }

    public string? SolidWorksModelCreation { get; set; }

    public string? SolidWorksBoneCreation { get; set; }

    public string? SolidWorksKitCreation { get; set; }

    public string? ObjectImport { get; set; }

    public string? MaterialTexture { get; set; }

    public string? ObjectMovementsKeyframes { get; set; }

    public string? Techniquesforlightingandrendering { get; set; }

    public string? CameraMovements { get; set; }

    public string? RenderParameter { get; set; }

    public string? FilmoraVoice { get; set; }

    public string? FilmoraText { get; set; }

    public string? EntireFilmora { get; set; }

    public string? SubmittedBy { get; set; }
}
