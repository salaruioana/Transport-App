using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TransportInfo
{
    public class Presenter:IPresenter
    {
        IModel _model;
        IView _view;

        public Presenter(in IView view, in IModel model)
        {
            _view = view;
            _model = model;
        }
        public void Init()//trebuie apelata pentru a initializa prezentarea
        {
            if (!_model.DataExists())
            {
                _view.Display("Fisierul cu orase nu exista." + Environment.NewLine, "red");
            }
            else
            {
                _model.InitializeData();
                _view.Display("Fisier incarcat: " + _model.CityCount + " orase." + Environment.NewLine, "magenta");
            }
        }

        public void Exit()
        {
            if (_model.SaveData())
                _view.Display("Fisierul a fost salvat." + Environment.NewLine, "magenta");
            _view.Display("La revedere.", "default");
            // Application.DoEvents(); // numai pentru Windows Forms
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
        // plus metodele de pe diagrama de clase

        public void AddCity(in City city)
        {
            try
            {
                if (_model.Add(city))
                {
                    _model.SaveData();
                    _view.Display("Orasul a fost adaugat." + Environment.NewLine, "green");
                }
                else
                    _view.Display("Eroare: orasul nu a putut fi adaugat." + Environment.NewLine, "red");
            }
            catch (Exception ex)
            {
                _view.Display(ex.Message + Environment.NewLine, "red");
            }
        }
        public City GetCity(in string name)
        {
            return _model.Search(name);
        }

        public bool CityExists(in string name)
        {
            return _model.Exists(name);
        }

        public void ComputeRoute(in string city1, in string city2)
        {
            City c1 = GetCity(city1);
            City c2 = GetCity(city2);
            double distance = Calculator.Distance(c1, c2);
            _view.Display(("Distanta intre " + city1 + " si " + city2 + " este: " + distance.ToString("F2") + " km."),"cyan");
            _view.Display(("Costul transportului intre " + city1 + " si " + city2 + " este: " + Calculator.Cost(distance).ToString("F2") + " lei."), "magenta");
        }

        void IPresenter.RemoveCity(in string name)
        {
            try
            {
                if (_model.Delete(name))
                    _view.Display("Orasul a fost sters." + Environment.NewLine, "green");
                else
                    _view.Display("Eroare: orasul nu a putut fi sters." + Environment.NewLine, "red");
            }
            catch (Exception ex)
            {
                _view.Display(ex.Message + Environment.NewLine, "red");
            }
        }
    }
}
