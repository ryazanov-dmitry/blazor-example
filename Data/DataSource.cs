using Microsoft.AspNetCore.Components;
using static blazor_example.Components.SimpleForm;

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
        return context.Products.Where(x => x.CategoryId == 1).Select(x => new DataModel
        {
            Id = x.Id,
            Name = x.Name,
            ImageUrl = x.Image
        }).ToList();
    }

    public void AddData(FormModel model)
    {
        context.Products.Add(new Product
        {
            Name = model.Value,
            CategoryId = 1,
            Image = model.ImageUrl
        });
        context.SaveChanges();

        OnChange?.Invoke();
    }
}



public class DataModel
{
    public int Id { get; internal set; }
    public string? Name { get; set; }
    public string ImageUrl { get; set; }
}