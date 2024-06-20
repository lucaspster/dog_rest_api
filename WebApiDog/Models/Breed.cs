namespace WebApiDog.Models
{
    public class Breed
    {
        public BreedAttributes Attributes { get; set; }
        public string Id { get; set; }
        public Relationships Relationships { get; set; }
        public string Type { get; set; }
    }
}