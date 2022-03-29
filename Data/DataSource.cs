using Microsoft.AspNetCore.Components;

namespace blazor_example.Data;

public class DataSource
{
    private readonly BlazorContext context;

    public DataSource(BlazorContext context)
    {
        this.context = context;
    }

    public event Action OnChange;

    public List<DataModel> GetData()
    {
        return context.Products.Select(x=>new DataModel{Id = x.Id, Name = x.Name}).ToList();
    }

    public void AddData(string name)
    {
        context.Products.Add(new Product { Name = name, CategoryId = 1 });
        context.SaveChanges();

        OnChange?.Invoke();
    }
}



public class DataModel
{
    public int Id { get; internal set; }
    public string? Name { get; set; }
}