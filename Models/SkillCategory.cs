namespace DevPortfolio.Models;

public class SkillCategory
{
    public required string Name { get; set; }
    public List<string> Skills { get; set; } = new();
}
