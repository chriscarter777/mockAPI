using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockAPI.Content;
using System.Data;

namespace MockAPI.Models
{
    public class DataRepository : IDataRepository
    {

        public int Size()
        {
            return Data.Places.Count;
        }

        public IEnumerable<Place> RetrieveAll()
        {
            return Data.Places;
        }

        public Place Retrieve(int id)
        {
            return Data.Places.Find(p => p.Id == id);
        }

        public void Add(Place place)
        {
            Data.Places.Add(place);
        }

        public void Delete(int id)
        {
            Place place = Retrieve(id);
            Data.Places.Remove(place);
        }

        public void Change(Place newPlace)
        {
            Place oldPlace = Retrieve(newPlace.Id);
            oldPlace.Name = newPlace.Name;
            oldPlace.Population = newPlace.Population;
        }

    }
}