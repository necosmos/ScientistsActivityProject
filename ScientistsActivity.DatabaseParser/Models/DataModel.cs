using System.ComponentModel.DataAnnotations.Schema;

namespace ScientistsActivity.DatabaseParser.Models;

public class DataModel
{
    public int Id { get; set; }

    public string Author { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Category { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime Date { get; set; }

    /// <summary>
    /// Split by comma
    /// </summary>
    public string KeyWords { get; set; } = null!;
}
