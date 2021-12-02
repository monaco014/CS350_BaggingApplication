namespace CS350_BaggingApplication.Models
{
    public class Packaging
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double WeightCapacity{ get; set; }
        public int HardItemLimit { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
    }
}