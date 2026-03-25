using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportInfo;

namespace TransportInfo
{
    public partial class FormView : Form,IView
    {
        private IPresenter _presenter;
        private IModel _model;

        public void SetPresenter(in IPresenter presenter)
        {
            _presenter = presenter;
        }

        public void Display(in string text, in string color)
        { 
            Color c = Color.Black;
            switch (color.ToLower())
            {
                case "red": c = Color.Red; break;
                case "green": c = Color.Green; break;
                case "magenta": c = Color.Magenta; break;
                case "blue": c = Color.Blue; break;
                default: c = Color.Black; break;
            }

            richTextBoxContinut.SelectionStart = richTextBoxContinut.TextLength;
            richTextBoxContinut.SelectionColor = c;
            richTextBoxContinut.AppendText(text + Environment.NewLine);
            richTextBoxContinut.ScrollToCaret();
        }
        public FormView(IModel model)
        {
            InitializeComponent();
            _model = model;
            // adaugam manual optiunile principale de navigare
            listBoxModUtilizare.Items.Add("Utilizator");
            listBoxModUtilizare.Items.Add("Administrator");
            listBoxModUtilizare.Items.Add("Iesire");

            RefreshCityLists();
        }


        public void RefreshCityLists()
        {
            // curatam listele anterioare
            comboBoxOrasul1.Items.Clear();
            comboBoxOrasul2.Items.Clear();
            comboBoxStergereOras.Items.Clear();

            string allCitiesString = _model.ListAll();

            if (!string.IsNullOrEmpty(allCitiesString))
            {
                // spargem string-ul in nume individuale
                string[] cityNames = allCitiesString.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string name in cityNames)
                {
                    comboBoxOrasul1.Items.Add(name);
                    comboBoxOrasul2.Items.Add(name);
                    comboBoxStergereOras.Items.Add(name);
                }
            }
        }

        private void listBoxModUtilizare_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCityLists();

            string selectedRole = listBoxModUtilizare.SelectedItem?.ToString();
            listBoxOptiuniDetaliate.Items.Clear();

            if (selectedRole == "Utilizator")
            {
                listBoxOptiuniDetaliate.Items.Add("Informatii despre o ruta");
                listBoxOptiuniDetaliate.Items.Add("Afisarea tuturor oraselor");
                // dezactiveaza panel-urile de Admin
                panelAdaugareOras.Enabled = false;
                panelStergere.Enabled = false;
            }
            else if (selectedRole == "Administrator")
            {
                listBoxOptiuniDetaliate.Items.Add("Introducerea unui nou oras");
                listBoxOptiuniDetaliate.Items.Add("Stergerea unui oras");
                listBoxOptiuniDetaliate.Items.Add("Afisarea tuturor oraselor");
                panelAdaugareOras.Enabled = true;
                panelStergere.Enabled = true;
            }
            else if (selectedRole == "Iesire")
            {
                _presenter.Exit();
            }
        }

        private void listBoxOptiuniDetaliate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = listBoxOptiuniDetaliate.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedOption)) return;

            // Echivalentul switch(choice) din varianta consola
            switch (selectedOption)
            {
                case "Afisarea tuturor oraselor":
                    string lista = _model.ListAll();
                    Display("Orasele disponibile sunt: " + lista, "magenta");
                    break;

                case "Informatii despre o ruta":
                    Display("Selectati orasele din listele derulante si apasati 'Afiseaza'.", "yellow");
                    break;

                case "Introducerea unui nou oras":
                    Display("Introduceti datele in campul de adaugare (Nume, Lat, Lon).", "yellow");
                    break;

                case "Stergerea unui oras":
                    Display("Selectati orasul din lista de stergere si apasati 'Sterge'.", "yellow");
                    break;
            }
        }



        private void buttonAfiseaza_Click(object sender, EventArgs e)
        {
            string oras1 = comboBoxOrasul1.Text;
            string oras2 = comboBoxOrasul2.Text;

            if (!string.IsNullOrEmpty(oras1) && !string.IsNullOrEmpty(oras2))
            {
                _presenter.ComputeRoute(oras1, oras2);
            }
            else
            {
                Display("Va rugam selectati ambele orase pentru ruta.", "red");
            }
        }


        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBoxAlegereOras.Text;
                string[] date = input.Split(';');

                if (date.Length == 3)
                {
                    string nume = date[0].Trim();

                    CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                    ci.NumberFormat.NumberDecimalSeparator = ".";

                    double lat = Convert.ToDouble(date[1].Trim(), ci);
                    double lon = Convert.ToDouble(date[2].Trim(), ci);

                    City orasNou = new City(nume, lat, lon);

                    _presenter.AddCity(orasNou);

                    RefreshCityLists();
                    textBoxAlegereOras.Clear();
                    Display("Orasul " + nume + " a fost adaugat cu succes!", "green");
                }
                else
                {
                    Display("Format invalid! Folositi: Nume; Latitudine.XX; Longitudine.XX", "red");
                }
            }
            catch (Exception ex)
            {
                Display("Eroare: Asigurati-va ca folositi PUNCT pentru zecimale si ; intre valori.", "red");
            }
        }


        private void buttonSterge_Click(object sender, EventArgs e)
        {
            string cityName = comboBoxStergereOras.Text;

            if (!string.IsNullOrEmpty(cityName))
            {
                // trimitem comanda la Presenter
                _presenter.RemoveCity(cityName);

                // dupa stergere, trebuie sa reimprospatam listele ca orasul sa dispara
                RefreshCityLists();
                comboBoxStergereOras.Text = "";
            }
            else
            {
                Display("Selectati un oras pentru a-l sterge!", "red");
            }
        }

    }
}
