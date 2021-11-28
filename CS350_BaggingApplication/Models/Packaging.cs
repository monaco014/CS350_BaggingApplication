namespace CS350_BaggingApplication.Models
{
    public class Packaging
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WeightCapacity{ get; set; }
        public int HardItemLimit { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
    }
}