namespace checkGiovanni.DTO
{
    public class GetPlateDTOcs
    {
        public Guid PlateId { get; set; } 
        public string? Name { get; set; }
        public string? Type { get; set; }
        public Decimal Price { get; set; }
    }
}
