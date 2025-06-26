namespace GviyaBackend.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ResidentId { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date {  get; set; }
    }
}
