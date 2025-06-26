namespace GviyaBackend.Models
{
    public class PaymentsForResident
    {
        public Resident Resident { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
