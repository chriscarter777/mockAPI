using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockAPI.Models;

namespace MockAPI.Content
{
    public class Data
    {
        public static List<Place> Places = new List<Place>
        {
            new Place { Id=0, Name="Portland", Population=2389228},
            new Place { Id=1, Name="Seattle", Population=3733580},
            new Place { Id=2, Name="Salem", Population=400408},
            new Place { Id=3, Name="Eugene", Population=247421},
            new Place { Id=4, Name="Roseburg", Population=21968},
            new Place { Id=5, Name="Medford", Population=208545},
            new Place { Id=6, Name="Bend", Population=165954},
        };
    }
}