namespace DevPortfolio.Models;

public class Project
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }
    public List<string> TechStack { get; set; } = new();
    public string? GitHubUrl { get; set; }
    public string? LiveUrl { get; set; }
    public bool Featured { get; set; }
    public required string ProjectType { get; set; }

}
