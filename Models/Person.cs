namespace WebApiPerson.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Age { get; set; }
    }
}
