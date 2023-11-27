namespace ScientistsActivity.GoogleSearch.Models;

public class DataModel
{
    public string Author { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Category { get; set; } = null!;

    public string Content { get; set; } = null!;
    public DateTime Date { get; set; }

    public List<string> KeyWordsArray { get; set; } = new();
    public string KeyWords => string.Join(", ", KeyWordsArray);
}
