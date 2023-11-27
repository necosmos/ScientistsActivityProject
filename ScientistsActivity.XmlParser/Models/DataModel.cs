namespace ScientistsActivity.XmlParser.Models;

public class DataModel
{
    public string Author { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string KeyWords { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime Date { get; set; }
}
