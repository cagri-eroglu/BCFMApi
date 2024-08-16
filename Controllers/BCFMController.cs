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


		[HttpPost("BCFMPost")]
		public IActionResult PostMessageCombined(
			[FromQuery] int? intBasedProperty = null,
			[FromQuery] string stringBasedProperty = "BC4M",
			[FromBody] PostBCFMDto data = null
	)
		{
			if (data != null)
			{
				if (intBasedProperty == null)
				{
					return BadRequest("Invalid request. intBasedProp shoudldnt be null");
				}

				return Ok(data);
			}
			else
			{
				if (intBasedProperty == null || string.IsNullOrEmpty(stringBasedProperty))
				{
					return BadRequest("Invalid request .");
				}

				var result = new PostBCFMDto
				{
					intBasedProperty = intBasedProperty.Value,
					stringBasedProperty = stringBasedProperty
				};

				return Ok(result);
			}
		}

	}


}
