namespace blazor_example.Data;

public class DataSource
{
    public static List<DataModel> GetData()
    {
        return new List<DataModel> {
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
    }
}



public class DataModel
{
    public Guid Id { get; internal set; }
    public string? Name { get; set; }
}