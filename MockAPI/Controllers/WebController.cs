using System.Collections.Generic;
using System.Web.Http;
using MockAPI.Models;
using System.Web.Mvc;

namespace MockAPI.Controllers
{
    public class WebController : ApiController
    {
        private IDataRepository repo;

        public WebController(IDataRepository dataRepository)
        {
            this.repo = dataRepository;
        }
      
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