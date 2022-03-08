using Microsoft.AspNetCore.Components;

namespace blazor_example.Data;

public class DataSource
{

    public static event Action OnChange;

    public static List<DataModel> Data =
        new List<DataModel> {
            new DataModel{
                Id = Guid.NewGuid(),
                Name = "Sintetic Data 1"
            },
            new DataModel{
                Id = Guid.NewGuid(),
                Name = "Sintetic Data 2"
            },
            new DataModel{
                Id = Guid.NewGuid(),
                Name = "Sintetic Data 3"
            },
        };

    public static List<DataModel> GetData()
    {
        return Data;
    }

    public static void AddData(string name)
    {
        Data.Add(new DataModel
        {
            Id = Guid.NewGuid(),
            Name = name
        });

        OnChange?.Invoke();
    }
}



public class DataModel
{
    public Guid Id { get; internal set; }
    public string? Name { get; set; }
}