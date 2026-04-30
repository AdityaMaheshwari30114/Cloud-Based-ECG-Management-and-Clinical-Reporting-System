using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetReports()
        {
            var reports = new List<object>
            {
                new { report_id = 1, patient_id = 1, device_id = 1, status = "Completed", report_date = "2024-04-30" }
            };
            return Ok(reports);
        }

        [HttpPost]
        public IActionResult CreateReport([FromBody] dynamic reportData)
        {
            return Ok(new { message = "Report created successfully", report_id = 1 });
        }

        [HttpGet("{id}")]
        public IActionResult GetReportById(int id)
        {
            return Ok(new { report_id = id, status = "Completed", patient_id = 1 });
        }
    }
}
