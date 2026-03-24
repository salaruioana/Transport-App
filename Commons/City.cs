using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public struct City
    {
        public readonly double Latitude, Longitude;
        public readonly string Name; // read only, pentru ca structura sa fie imutabila

        public City(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }

}
