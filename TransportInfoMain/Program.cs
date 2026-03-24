using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public enum ViewType
    {
        Console,
        WinForms
    }

    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ViewType selectedView = ViewType.WinForms; // Schimbă în ViewType.Console pentru terminal

            IModel model = new Model(); // Modelul e comun
            IView view;
            IPresenter presenter;

            if (selectedView == ViewType.WinForms)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                view = new FormView(model);
                presenter = new Presenter(view, model);
                view.SetPresenter(presenter);

                Application.Run((Form)view);
            }
            else
            {
                view = new ConsoleView(model);
                presenter = new Presenter(view, model);
                view.SetPresenter(presenter);
                ((ConsoleView)view).Start();
            }
        }
    }
}
