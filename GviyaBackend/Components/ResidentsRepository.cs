using GviyaBackend.Models;

namespace GviyaBackend.Components
{
    public interface IResidentsRepository
    {
        Task<Resident[]> GetResidentsAsync();
        Task<PaymentsForResident> GetResidentByIdWithPaymentsAsync(int id);
        Task<bool> AddPaymentForResidentAsync(int residentId, Payment payment);
    }
    public class ResidentsRepository:IResidentsRepository
    {
        public async Task<Resident[]> GetResidentsAsync()
        {
            return Data.Residents;
        }
        public async Task<PaymentsForResident> GetResidentByIdWithPaymentsAsync(int id)
        {
            return new PaymentsForResident
            {
                Resident = Data.Residents.FirstOrDefault(x => x.ResidentId == id),
                Payments = Data.Payments.Where(x => x.ResidentId == id).ToList()
            };
        }
        public async Task<bool> AddPaymentForResidentAsync(int residentId,Payment payment)
        {
            payment.ResidentId = residentId;
            payment.PaymentId = Data.Payments.Max(x=>x.PaymentId)+1;
            Data.Payments.ToList().Add(payment);
            //  Data.Payments.save() I'm pretending it's a data base.
            return true;
        }
    }
}
