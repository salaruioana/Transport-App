using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public interface IView
    {
        void Display(in string text, in string color);
        void SetPresenter(in IPresenter presenter);

    }
}
