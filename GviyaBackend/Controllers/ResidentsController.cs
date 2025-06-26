using GviyaBackend.Components;
using GviyaBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GviyaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentsController : ControllerBase
    {
        private readonly IResidentsRepository _residentsRepository;
        public ResidentsController(IResidentsRepository residentsRepository)
        {
            _residentsRepository = residentsRepository;
        }
        [HttpGet]
        public async Task<Resident[]> GetAsync() {
            return await _residentsRepository.GetResidentsAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<PaymentsForResident> GetResidentByIdAsync(int id)
        {
            return await _residentsRepository.GetResidentByIdWithPaymentsAsync(id);
        }

        [HttpPost]
        [Route("{id}/payments")]
        public async Task<bool> AddPaymentForResidentAsync(int residentId, Payment payment)
        {
            return await _residentsRepository.AddPaymentForResidentAsync(residentId,payment);
        }
    }
}
