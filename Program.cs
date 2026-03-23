using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{

    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IModel model = new Model();
            //pentru varianta consola, se poate inlocui IView view new ConsoleView(model)
            FormView view = new FormView(model);
            IPresenter presenter = new Presenter(view, model);
            view.SetPresenter(presenter);

            presenter.Init();
            //asta se comenteaza pentru consola
            view.RefreshCityLists();
            //asta se decomenteaza pentru consola
            //((ConsoleView)view).Start();
            //asta se comenteaza pentru consola
            Application.Run(view);
        }
    }
}
