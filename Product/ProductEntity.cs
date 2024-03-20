
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagementApi.Product
{
    public record  ProductEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}