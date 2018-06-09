using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.Models;

namespace TripTracker.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        public TripsController(Models.Repository repository)
        {
            _repository = repository;
        }

        private Models.Repository _repository;


        // GET api/Trips
        [HttpGet]
        public IEnumerable<Models.Trip> Get()
        {
            return _repository.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Trip value)
        {
            _repository.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Trip value)
        {
            _repository.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}
