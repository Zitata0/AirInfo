
using AirInfo.Data;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Windows;

namespace AeroInfo
{
    public partial class MainWindow : Window
    {
        private Parser parser;
        private City[] cities;
        private Airport[]? airports;
        private List<Airport>? selectedAirports;
        private Schedules[]? schedules;
        private string lastSelect;
        public MainWindow()
        {
            InitializeComponent();

            string APIKey = "0672fc7e-1fc1-4277-be40-b7578a5a1406";
            parser = new Parser(APIKey);

            lastSelect = "";
            cities = parser.ParseCities();
            CitiesComboBox.ItemsSource = cities;
        }

        private void ConfirmSelectClick(object sender, RoutedEventArgs e)
        {
            if (selectedAirports != null && !lastSelect.Equals(selectedAirports[AirportComboBox.SelectedIndex].Name))
            {
                schedules = parser.ParseSchedules(selectedAirports[AirportComboBox.SelectedIndex]);
            }
            if (schedules != null)
            {
                SchedulesDataGrid.ItemsSource = schedules;
            }
            if (selectedAirports != null)
            {
                lastSelect = selectedAirports[AirportComboBox.SelectedIndex].Name;
            }
        }

        private void CitiesSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (airports == null)
            {
                airports = parser.ParseAirports();
                AirportComboBox.ItemsSource = airports;
            }
            int selectedCityId = CitiesComboBox.SelectedIndex;
            selectedAirports = new List<Airport>();

            for (int i = 0; i < airports.Length; i++)
            {
                if (
                    (cities[selectedCityId].Lat + 2D > airports[i].Lat) && (cities[selectedCityId].Lat - 2D < airports[i].Lat)
                    &&
                    (cities[selectedCityId].Lng + 2D > airports[i].Lng) && (cities[selectedCityId].Lng - 2D < airports[i].Lng)
                    &&
                    (cities[selectedCityId].CountryCode.Equals(airports[i].CountryCode))
                   )
                {
                    selectedAirports.Add(airports[i]);
                }
            }

            AirportComboBox.ItemsSource = selectedAirports;

            AirportComboBox.Focusable = true;
            AirportComboBox.IsHitTestVisible = true;
            ConfirmSelectButton.Focusable = false;
            ConfirmSelectButton.IsHitTestVisible = false;
        }

        private void AirportsSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ConfirmSelectButton.Focusable = true;
            ConfirmSelectButton.IsHitTestVisible = true;
        }

        private void SchedulesDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
