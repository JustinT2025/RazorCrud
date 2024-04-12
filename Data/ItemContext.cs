using Domain.Models;
using Microsoft.EntityFrameworkCore;
//using UI.Models;

namespace RazorCrudUI.Models;

public class ItemContext : DbContext
{
    public ItemContext(DbContextOptions<ItemContext> options) : base(options)
    {
    }

    // whatever you name this collection will be your table name
    public DbSet<ItemModel> Items { get; set; } = default!;

    
}
