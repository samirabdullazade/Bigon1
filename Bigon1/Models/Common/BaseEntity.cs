using System.ComponentModel.DataAnnotations;

namespace Bigon1.Models.Common
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? EditedAt { get; set; }
    }
}
