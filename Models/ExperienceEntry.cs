namespace DevPortfolio.Models;

public enum ExperienceType
{
    Work,
    Education
}

public class ExperienceEntry
{
    public required string Title { get; set; }
    public required string Organization { get; set; }
    public required string Period { get; set; }
    public ExperienceType Type { get; set; } = ExperienceType.Work;
    public List<string> Highlights { get; set; } = new();
}
