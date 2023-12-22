namespace checkGiovanni.Entity
{
    public class Plate
    {
        public Guid PlateId { get; set; } = Guid.NewGuid();
        public string? Name { get; set; } 
        public string? Type { get; set; } 
        public Decimal Price { get; set; } 
    }
}
