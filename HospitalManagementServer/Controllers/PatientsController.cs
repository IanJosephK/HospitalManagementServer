
using HospitalManagementServer.API;
using HospitalManagementServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : Controller
    {
        private readonly PatientsAPIDbcontext dbContext;

        public PatientsController(PatientsAPIDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            return Ok(await dbContext.Patients.ToListAsync());

        }

        [HttpPost]
        public async Task<IActionResult> PostPatient(AddPatientRequest addPatientRequest)
        {
            Patient patient = new Patient()
            {
                ID = Guid.NewGuid(),
                Addresses = addPatientRequest.Addresses,
                BillAmount = addPatientRequest.BillAmount,
                Code = addPatientRequest.Code,
                Name = addPatientRequest.Name,
                Phone = addPatientRequest.Phone,
            };

            await dbContext.Patients.AddAsync(patient);
            await dbContext.SaveChangesAsync();

            return Ok(patient);
        }
    }
}
