using Syncfusion.DataSource;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfListVIewCheckBox
{
    public partial class Form1 : Form
    {
        ObservableCollection<CountryInfo> countryInfoCollection = new ObservableCollection<CountryInfo>();
        ObservableCollection<int> checkedIndexes = new ObservableCollection<int>();

        public Form1()
        {
            InitializeComponent();
            sfListView1.ShowCheckBoxes = true;
            sfListView1.DataSource = GetDataSource();
            sfListView1.ItemChecked += SfListView1_ItemChecked;

            sfListView1.CheckBoxSelectionMode = Syncfusion.WinForms.ListView.Enums.CheckBoxSelectionMode.CheckOnItemClick;
            sfListView1.DisplayMember = "CountryName";

            ObservableCollection<CountryInfo> GetDataSource()
            {
                countryInfoCollection.Add(new CountryInfo() { CountryName = "China", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "India", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Japan", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Malaysia", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "UnitedSates", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Canada", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Germany", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "UnitedKingdom", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Italy", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "NewZealand", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Australia", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Finland", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Sweden", Continent = "Asia" });
                countryInfoCollection.Add(new CountryInfo() { CountryName = "Netherland", Continent = "Asia" });

                return countryInfoCollection;
            }
            
        }

        private void SfListView1_ItemChecked(object sender, Syncfusion.WinForms.ListView.Events.ItemCheckedEventArgs e)
        {
            checkedIndexes.Clear();
            foreach (var allItems in sfListView1.View.Items)
            {
                foreach (var checkedItem in sfListView1.CheckedItems)
                {
                    if (allItems == checkedItem)
                    {
                        checkedIndexes.Add(sfListView1.View.DisplayItems.IndexOf(allItems));
                    }
                }
            }
            sfListView2.DataSource = checkedIndexes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class CountryInfo
    {
        public string CountryName { get; set; }
        public string Continent { get; set; }
    }
}
