namespace ScientistsActivity.Core.Dto;

public class ParametersDto
{
    public string? Name { get; set; }
    public double? NameWeight { get; set; }

    public string? Themes { get; set; }
    public double? ThemesWeight { get; set; }

    public string[]? KeyWordsArray { get; set; }
    public string KeyWords => string.Join(", ", KeyWordsArray ?? Array.Empty<string>());

    public double? KeyWordsWeight { get; set; }

    public DateTime? Date { get; set; }
    public double? DateWeight { get; set; }

    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public double? RangeWeight { get; set; }

    public int GetScore()
    {
        var score = 0;

        if (Name is not null)
            score += 2;

        if (Themes is not null)
            score += 2;

        if (KeyWordsArray is not null)
            score += 2;

        if (Date is not null || From is not null || To is not null)
            score += 2;

        if (From is not null && To is not null)
            score += 2;

        return score;
    }
}
