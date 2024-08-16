using BCFMApi.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BCFMApi.Controllers
{
	public class BCFMController : Controller
	{
		[HttpGet("BCFMGet")]
		public IActionResult GetMessage()
		{
			var dto = new GetBCFMDto
			{
				Msg = "BC4M"
			};
			return Json(dto);
		}

		[HttpGet("health")]
		public IActionResult HealthCheck() => Ok(new { status = "Healthy", timestamp = DateTime.Now });

		[HttpPost("BCFM_podst")]
		public IActionResult PostMethod([FromBody] PostBCFMDto data)
		{
			if (data == null)
			{
				return BadRequest("Invalid data provided.");
			}

			if (string.IsNullOrEmpty(data.stringBasedProperty))
			{
				return BadRequest("Invalid data provided.");
			}

			return Ok(data);
		}

	}


}
