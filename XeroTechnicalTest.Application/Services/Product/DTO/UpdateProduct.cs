namespace XeroTechnicalTest.Domain.Services.DTO
{
    public class UpdateProduct
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal DeliveryPrice { get; set; }
    }
}