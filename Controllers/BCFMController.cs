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
			[FromQuery] int? BCFMInt = null,
			[FromQuery] string BCFMString= "BC4M",
			[FromBody] PostBCFMDto data = null
	)
		{
			if (data != null) { 
			
				if (BCFMInt == null)
				{
					return BadRequest("Invalid request. int based property shoudldnt be null");
				}

				return Ok(data);
			}
			else
			{
				if (BCFMInt == null || string.IsNullOrEmpty(BCFMString))
				{
					return BadRequest("Invalid request .");
				}

				var result = new PostBCFMDto
				{
					BCFMInt = BCFMInt.Value,
					BCFMString= BCFMString
				};

				return Ok(result);
			}
		}

	}


}
