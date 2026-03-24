using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public class ConsoleView:IView
    {
        IPresenter _presenter;
        IModel _model;
        List<MenuOption> _menuOptions;
        public ConsoleView(in IModel model)
        {
           _model = model;
        }
        public void Start()
        {
            UserChoice choice = UserChoice.Undefined;
            MenuState menuState = MenuState.Main;

            while (choice != UserChoice.Exit)
            {
                // preia comanda in functie de starea curenta a meniului

                choice = GetMenuOption(menuState);

                switch (choice)
                {
                    // comenzi
                    case UserChoice.Route:
                        string cn1, cn2;
                        GetTwoCities(out cn1, out cn2);
                        _presenter.ComputeRoute(cn1, cn2);
                        break;
                    case UserChoice.RemoveCity:
                        string cityName = GetCity();
                        // de completat
                        _presenter.RemoveCity(cityName);
                        break;
                    case UserChoice.AddCity:
                        City c = InputCity();
                        // de completat
                        _presenter.AddCity(c);
                        break;
                    case UserChoice.List:
                        ListAll();
                        break;
                    case UserChoice.Exit:
                        //de completat
                        // Nu se realizeaza inchiderea aplicatiei din layerul de prezentare, ci se transmite intentia catre controller pentru a opri toate procesele
                        Console.WriteLine("Închidere aplicație...");
                        _presenter.Exit();
                        break;

                    // navigare meniuri
                    case UserChoice.AdminMenu:
                        menuState = MenuState.Administrator;
                        break;
                    case UserChoice.UserMenu:
                        menuState = MenuState.User;
                        break;
                    case UserChoice.PreviousMenu:
                        menuState = MenuState.Main;
                        break;
                }
            }

        }

        private UserChoice GetMenuOption(in MenuState menuType)
        {
            string action = "";

            switch (menuType)
            {
                case MenuState.Main:
                    Menus.MainMenu(out _menuOptions, out action);
                    break;
                case MenuState.Administrator:
                    Menus.AdminMenu(out _menuOptions, out action);
                    break;
                case MenuState.User:
                    Menus.UserMenu(out _menuOptions, out action);
                    break;
            }
            UserChoice choice = UserChoice.Undefined;
            while (choice == UserChoice.Undefined)
            {
                Display(action + Environment.NewLine, "yellow");

                for (int i = 0; i < _menuOptions.Count; i++)
                    Display(_menuOptions[i].Number + ". " + _menuOptions[i].Text, "default");

                Console.Write(Environment.NewLine + "Optiunea dumneavoastra: ");
                string userChoiceNumber = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < _menuOptions.Count; i++)
                {
                    if (userChoiceNumber == _menuOptions[i].Number)
                    {
                        choice = _menuOptions[i].Choice;
                        break;
                    }
                }
            }

            return choice;

        }

        private void GetTwoCities(out string cityName1, out string cityName2)
        {
            Console.WriteLine("Introduceti primul oras: ");
            cityName1 = Console.ReadLine();
            Console.WriteLine("Introduceti al doilea oras: ");
            cityName2 = Console.ReadLine();
        }
        private string GetCity()
        {
            Console.WriteLine("Introduceti numele orasului: ");
            string city = Console.ReadLine();
            return city;
        }

        //menita sa creeze un oras nou
        private City InputCity()
        {
            Console.WriteLine("Introduceti numele orasului: ");
            City city = new City();
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine("Introduceti latitudinea (ex: 47.15): ");
                double lat = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduceti longitudinea (ex: 27.58): ");
                double lon = Convert.ToDouble(Console.ReadLine());

                return new City(name, lat, lon);
            }
            catch (FormatException)
            {
                Console.WriteLine("Formatul latitudinii/longitudinii este invalid. Vă rugăm să introduceți un număr valid.");
                return InputCity(); // Recurent pentru a permite reintroducerea datelor
            }
        }

        private void ListAll()
        {
            Console.WriteLine("Orasele disponibile sunt: ");
            string orase = _model.ListAll();

            Display(orase + Environment.NewLine, "cyan");
        }

        public void Display(in string text, in string color)
        {
            ConsoleColor c = ConsoleColor.DarkGray;

            switch (color)
            {
                case "default": c = ConsoleColor.White; break;
                case "red": c = ConsoleColor.Red; break;
                case "green": c = ConsoleColor.Green; break;
                case "blue": c = ConsoleColor.Blue; break;
                case "yellow": c = ConsoleColor.Yellow; break;
                case "magenta": c = ConsoleColor.Magenta; break;

            }
            Console.ForegroundColor = c;
            Console.WriteLine(text);
        }

        public void SetPresenter(in IPresenter presenter)
        {
            _presenter = presenter;
        }

    }
}
