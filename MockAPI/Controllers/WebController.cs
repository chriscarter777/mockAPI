using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MockAPI.Models;
using MockAPI.Content;

namespace MockAPI.Controllers
{
    public class WebController : ApiController
    {
        DataRepository repo = new DataRepository();
        
        // GET api/<controller>
        public IEnumerable<Place> Get()
        {
            return repo.RetrieveAll();
        }

        // GET api/<controller>/i
        public Place Get(int id)
        {
            return repo.Retrieve(id);
        }

        // POST api/<controller>
        public void Post(Place place)
        {
            repo.Add(place);
        }

        // PUT api/<controller>/i
        public void Put(int id, Place place)
        {
            repo.Change(place);
        }

        // DELETE api/<controller>/i
        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}