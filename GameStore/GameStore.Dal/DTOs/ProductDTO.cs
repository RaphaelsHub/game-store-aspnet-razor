namespace GameStore.Dal.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal OriginalPrice { get; set; } = 0;
        public decimal DiscountedPrice { get; set; }  = 0;
        public decimal CurrentPrice => OriginalPrice - DiscountedPrice;
        public string Category { get; set; } = string.Empty;
        public string TemplateInfo { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = false;
        public string Genre { get; set; } = string.Empty;
        public string MultiTags { get; set; } = string.Empty;
        
        public byte[] Image { get; set; } = Array.Empty<byte>();
    }
}