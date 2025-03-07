using BuisnessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using RepositoryLayer.Context;

namespace GreetingApp.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        private IGreetingBL _greetingBLinstance;
        
        public GreetingController(IGreetingBL greeting)
        {
            _greetingBLinstance = greeting;
        }
        [HttpGet]
        public IActionResult Get()
        {
            ResponseBody<string> response = new ResponseBody<string>();
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
        public IActionResult Delete([FromQuery] int id)
        {
            ResponseBody<string> response = new ResponseBody<string>();
            response.message = _greetingBLinstance.deleteMessage(id);
            return Ok(response);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] string xy, [FromQuery] int id )
        {
            ResponseBody<string> response = new ResponseBody<string>();
            response.message = _greetingBLinstance.updateMessage(id, xy);
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

        [HttpGet("SimpleGreeting")]
        public IActionResult SimpleGreeting()
        {
            string result = _greetingBLinstance.SimpleGreeting();
            ResponseBody<string> response = new ResponseBody<string>();
            response.status = "200";
            response.message = "Greeting sent";
            response.data = result;
            return Ok(response);
        }

        [HttpGet("GetGreeting")]
        public IActionResult GetGreeting([FromQuery] string? firstName, [FromQuery]string? lastName)
        {
            string result = _greetingBLinstance.GetGreeting(firstName,lastName);
            ResponseBody<string> response = new ResponseBody<string>();
            response.status = "200";
            response.message = "Greeting sent";
            response.data = result;
            return Ok(response);
        }

        [HttpPost("AddMessage")]
        public IActionResult addMessage([FromBody] string message)
        {
            ResponseBody<string> response = new ResponseBody<string>();
            response.message = _greetingBLinstance.addMessages(message);
            return Created("Created",response);
        }

        [HttpPost("FindMessage")]
        public IActionResult findMessage([FromBody] int id)
        {
            ResponseBody<string> response = new ResponseBody<string>();
            response.message = _greetingBLinstance.findMessage(id);
            return Ok(response);
        }

        [HttpGet("GetAllMessages")]
        public IActionResult getMessages()
        {
            var list = _greetingBLinstance.getAllMessages();
            return Ok(list);
        }
    }
}
