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

		//[HttpPost("BCFM_post")]
		//public IActionResult PostMethod([FromBody] PostBCFMDto data)
		//{
		//	if (data == null)
		//	{
		//		return BadRequest("Invalid request.");
		//	}

		//	if (string.IsNullOrEmpty(data.stringBasedProperty))
		//	{
		//		return BadRequest("Invalid request.");
		//	}

		//	return Ok(data);
		//}

		//[HttpPost("BCFM_post_query")]
		//public IActionResult PostMessageWithQuery([FromQuery] int? intBasedProperty = null, [FromQuery] string stringBasedProperty = "BC4M ♥")
		//{
		//	if (intBasedProperty == null || string.IsNullOrEmpty(stringBasedProperty))
		//	{
		//		return BadRequest("Invalid data provided.");
		//	}

		//	var result = new PostBCFMDto
		//	{
		//		intBasedProperty = intBasedProperty.Value,
		//		stringBasedProperty = stringBasedProperty
		//	};

		//	return Ok(result);
		//}

		[HttpPost("BCFMPost")]
		public IActionResult PostMessageCombined(
			[FromQuery] int? intBasedProperty = null,
			[FromQuery] string stringBasedProperty = "BC4M",
			[FromBody] PostBCFMDto data = null
	)
		{
			if (data != null)
			{
				if (string.IsNullOrEmpty(stringBasedProperty) && intBasedProperty == null)
				{
					return BadRequest("Invalid request. intBasedProp shoudlndt be null");
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
