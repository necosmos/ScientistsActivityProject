using ScientistsActivity.Core.Dto;
using ScientistsActivity.GoogleSearch.Models;

namespace ScientistsActivity.GoogleSearch.BusinessLogic;

public class FilterData
{
    public IEnumerable<DataModel> Filter(IEnumerable<DataModel> data, ParametersDto dto, int maxDataSize = 10)
    {
        var filteredData = data;

        if (!string.IsNullOrEmpty(dto.Name))
        {
            filteredData = filteredData
                .Where(d => d.Author.ToLower().Contains(dto.Name.ToLower()));
        }

        if (!string.IsNullOrEmpty(dto.Themes))
        {
            filteredData = filteredData
                .Where(d => d.Category.ToLower().Contains(dto.Themes.ToLower()));
        }

        if (!string.IsNullOrEmpty(dto.KeyWords))
        {
            filteredData = filteredData
                .Where(d => d.KeyWords.ToLower().Contains(dto.KeyWords.ToLower()));
        }

        if (dto.Date is not null)
        {
            filteredData = filteredData
                .Where(d => d.Date == dto.Date);
        }

        if (dto.From is not null && dto.Date is null)
        {
            filteredData = filteredData
                .Where(d => d.Date >= dto.From);
        }

        if (dto.To is not null && dto.Date is null)
        {
            filteredData = filteredData
                .Where(d => d.Date <= dto.To);
        }

        return filteredData
            .Take(maxDataSize);
    }
}
