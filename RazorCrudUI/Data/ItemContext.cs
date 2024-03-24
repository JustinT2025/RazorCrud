using Microsoft.EntityFrameworkCore;
using RazorCrudUI.Models;

namespace RazorCrudUI.Data;

public class ItemContext : DbContext
{
    public ItemContext(DbContextOptions<ItemContext> options) : base(options)
    {
    }

    // whatever you name this collection will be your table name
    public DbSet<ItemModel> Items { get; set; } = default!;

    
}
