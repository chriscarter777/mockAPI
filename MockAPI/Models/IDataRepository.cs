using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAPI.Models
{
    public interface IDataRepository
    {
        int Size();
        IEnumerable<Place> RetrieveAll();
        Place Retrieve(int id);
        void Add(Place place);
        void Delete(int id);
        void Change(Place place);
    }
}
