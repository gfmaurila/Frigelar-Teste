using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("User")]
    public class User : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
    }
}
