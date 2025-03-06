using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;

namespace GreetingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            ResponseBody<string> response = new ResponseBody<string>();
            response.data = null;
            response.message = "Hello from greeting App";
            response.status = "200";
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string x)
        {
            ResponseBody<string> response = new ResponseBody<string>();
            response.data = x;
            response.message = "Message Created";
            response.status = "201";
            return Created(response.message,response);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            ResponseBody<string> response = new ResponseBody<string>();
            response.data = null;
            response.message = "Deleted Message";
            response.status = "200";
            return Ok(response);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] string xy )
        {
            ResponseBody<string> response = new ResponseBody<string>();
            response.data = xy;
            response.message = "Message Updated";
            response.status = "200";
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put([FromBody] string xy) {
            ResponseBody<string> response = new ResponseBody<string>();
            response.data = xy;
            response.message = "Message Updated Completely";
            response.status = "200";
            return Ok(response);
        }
    }
}
