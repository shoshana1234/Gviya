namespace GviyaBackend.Models
{
    public class Resident
    {
        public int ResidentId { get; set; }
        public string? IdNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
    }
}
