using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDevices()
        {
            var devices = new List<object>
            {
                new { device_id = 1, device_name = "ECG Monitor Pro" },
                new { device_id = 2, device_name = "Portable ECG Device" }
            };
            return Ok(devices);
        }

        [HttpPost]
        public IActionResult CreateDevice([FromBody] dynamic deviceData)
        {
            return Ok(new { message = "Device created successfully", device_id = 1 });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDevice(int id, [FromBody] dynamic deviceData)
        {
            return Ok(new { message = "Device updated successfully" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDevice(int id)
        {
            return Ok(new { message = "Device deleted successfully" });
        }
    }
}
