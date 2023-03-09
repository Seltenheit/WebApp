using System.ComponentModel.DataAnnotations;

namespace TestWebApp.Domain.Models
{
    public class Catalog
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public virtual Catalog? Parent { get; set; }
        public virtual ICollection<Catalog> Children { get; set; } = new List<Catalog>();


    }
}
