
using System.ComponentModel.DataAnnotations;

namespace Persistence.Entities;

public class CategoryEntity
{
    [Key]
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;

    public ICollection<EventEntity> Events { get; set; } = [];
}