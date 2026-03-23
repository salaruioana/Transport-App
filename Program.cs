using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IModel model = new Model();
            IView view = new ConsoleView(model);
            IPresenter presenter = new Presenter(view, model);
            view.SetPresenter(presenter);
            ((ConsoleView)view).Start();
        }
    }
}
