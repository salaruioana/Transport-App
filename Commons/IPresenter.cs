using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public interface IPresenter
    {
        void AddCity(in City c);
        bool CityExists(in string name);
        void ComputeRoute(in string city1, in string city2);
        void Exit();
        City GetCity(in string name);
        void Init();
        void RemoveCity(in string name);
    }
}
