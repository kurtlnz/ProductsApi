using System.ComponentModel.DataAnnotations;

namespace XeroTechnicalTest.Endpoints.V1.Product
{
    public class CreateProductRequest
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal DeliveryPrice { get; set; }
    }
}