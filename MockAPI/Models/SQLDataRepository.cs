using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockAPI.Content;
using System.Data;
using MockAPI.Infrastructure;

namespace MockAPI.Models
{
    public class SQLDataRepository : IDataRepository
    {
        private MockAPIDbContext context = new MockAPIDbContext();

        public int Size()
        {
            return context.Places.Count();
        }

        public IEnumerable<Place> RetrieveAll()
        {
            return context.Places;
        }

        public Place Retrieve(int id)
        {
            return context.Places.Where(p => p.Id == id).FirstOrDefault();
        }

        public void Add(Place place)
        {
            context.Places.Add(place);
        }

        public void Delete(int id)
        {
            Place place = Retrieve(id);
            context.Places.Remove(place);
        }

        public void Change(Place newPlace)
        {
            Place oldPlace = Retrieve(newPlace.Id);
            oldPlace.Name = newPlace.Name;
            oldPlace.Population = newPlace.Population;
        }

    }
}