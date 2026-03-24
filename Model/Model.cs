/**************************************************************************
 *                                                                        *
 *  File:        Model.cs                                                 *
 *  Copyright:   (c) 2008-2024, Florin Leon                               *
 *  E-mail:      florin.leon@academic.tuiasi.ro                           *
 *  Website:     http://florinleon.byethost24.com/lab_ip.html             *
 *  Description: TransportInfo application with MVC architecture.         *
 *               Model class. (Software Engineering lab 6)                *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace TransportInfo
{
    public class Model : IModel
    {
        private const string _CityFileName = "cities.txt";
        private List<City> _cityList;
        private bool _wasModified; // the city list will be saved in the end only if it was modified

        public int CityCount => _cityList.Count;

        public Model()
        {
            _cityList = new List<City>();
            _wasModified = false;
        }

        /// <summary>
        /// Checks whether the file with the cities exists
        /// </summary>
        public bool DataExists()
        {
            if (!File.Exists(_CityFileName))
            {
                _wasModified = true;
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Reads the cities from the file
        /// </summary>
        public void InitializeData()
        {
            var sr = new StreamReader(_CityFileName);
            string line;
            while ((line = sr.ReadLine()) != null)
                _cityList.Add(ParseCityLine(line));
            sr.Close();
        }

        /// <summary>
        /// Adds a city to the city list
        /// </summary>
        public bool Add(City city)
        {
            // daca un oras cu acelasi nume exista deja, el va fi sters
            bool overwrite = false;

            for (int i = 0; i < _cityList.Count; i++)
            {
                if (_cityList[i].Name.Trim().ToUpper() == city.Name.Trim().ToUpper())
                {
                    _cityList.RemoveAt(i--);
                    overwrite = true;
                }
            }

            // adugarea noului oras
            _cityList.Add(city);
            _wasModified = true;
            return !overwrite;
        }

        /// <summary>
        /// Deletes a city identified by name from the city list
        /// </summary>
        public bool Delete(string cityName)
        {
            for (int i = 0; i < _cityList.Count; i++)
            {
                if (_cityList[i].Name == cityName)
                {
                    _cityList.RemoveAt(i);
                    _wasModified = true;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks whether a city identified by name exists
        /// </summary>
        public bool Exists(string cityName)
        {
            for (int i = 0; i < _cityList.Count; i++)
            {
                if (_cityList[i].Name == cityName)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Returns a City object whose name is the string cityName
        /// </summary>
        public City Search(string cityName)
        {
            // cauta un oras dupa nume si returneaza obiectul corespunzator
            for (int i = 0; i < _cityList.Count; i++)
            {
                if (_cityList[i].Name == cityName)
                    return _cityList[i];
            }

            return new City();
        }

        /// <summary>
        /// Returns a string with all the names of cities concatenated
        /// </summary>
        public string ListAll()
        {
            if (_cityList.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();
            sb.Append(_cityList[0].Name);

            for (int i = 1; i < _cityList.Count; i++)
            {
                sb.Append(", ");
                sb.Append(_cityList[i].Name);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Saves the data only if the city list was modified
        /// </summary>
        /// <returns>Returns true if the new data was saved</returns>
        public bool SaveData()
        {
            if (_wasModified)
            {
                var sw = new StreamWriter(_CityFileName);

                for (int i = 0; i < _cityList.Count; i++)
                {
                    City c = _cityList[i];
                    sw.WriteLine(c.Name + "\t" + c.Latitude + "\t" + c.Longitude);
                }

                sw.Close();
                return true;
            }
            else
                return false;
        }

        private static City ParseCityLine(string line)
        {
            // Verificăm dacă linia are text
            if (string.IsNullOrWhiteSpace(line)) return new City("", 0, 0);

            // Tăiem după Tab sau Spațiu
            string[] toks = line.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Dacă nu avem 3 elemente, returnăm un oraș cu nume gol ca să știm că e invalid
            if (toks.Length < 3) return new City("", 0, 0);

            try
            {
                string nume = toks[0];
                // InvariantCulture rezolvă eroarea de conversie (punct vs virgulă)
                double lat = double.Parse(toks[1], System.Globalization.CultureInfo.InvariantCulture);
                double lon = double.Parse(toks[2], System.Globalization.CultureInfo.InvariantCulture);

                return new City(nume, lat, lon);
            }
            catch
            {
                // În caz de eroare la numere, returnăm oraș invalid
                return new City("", 0, 0);
            }
        }
    }
}