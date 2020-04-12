using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> GetEventAsync()
        {
            var result = await getDataFromDB();
            return Ok(result);
        }

        private async Task<string> getDataFromDB()
        {
            return "dhg";
        }

        // GET api/<controller>/5
        //[HttpGet("{id}")]
       // public string Get(int id)
       // {
       //     return "value";
       // }

        // POST api/<controller>
        [HttpPost]
        public async void Task<addEventAsync>([FromBody]Event newEvent)
        {
            var result = await insertDataToDB(newEvent);
        }

        private async Task<string> insertDataToDB(Event newEvent)
        {
            return $"New event whit name:{newEvent.Name} whit id:{newEvent.Id}";
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public class Event
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }
    }
}
