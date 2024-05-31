using Bigon1.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Bigon1.Models
{
    public class Category: BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string? Description { get; set; }
        public Category? Parent { get; set; }
        public Guid? ParentId { get; set; }
    }
}
