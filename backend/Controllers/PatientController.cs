using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPatients()
        {
            var patients = new List<object>
            {
                new { id = 1, name = "John Doe", age = 45 }
            };
            return Ok(patients);
        }
    }
}
