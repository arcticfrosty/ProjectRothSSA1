namespace ProjectRothSSA1.Models.Data;

public partial class Category {
    public int CategoryId {
        get; set;
    }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
