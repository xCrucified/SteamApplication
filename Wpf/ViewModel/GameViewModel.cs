using data_access.Entities;
using SteamApplication.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Wpf.Windows;

namespace Wpf.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Game> gameList = new ObservableCollection<Game>();
        SteamDb db = new SteamDb();
        public void Add()
        {
            if (gameList != null)
            {
                db.Add(gameList);
            }
        }

        private string name;
        private string description;
        private int cost;
        private int rate;
        private int company;
        private int category;
        private int platform;

        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public int Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged(nameof(Cost));
            }
        }
        public int Rate
        {
            get { return rate; }
            set
            {
                rate = value;
                OnPropertyChanged(nameof(Rate));
            }
        }
        public int Company
        {
            get { return company; }
            set
            {
                company = value;
                OnPropertyChanged(nameof(Company));
            }
        }
        public int Platform
        {
            get { return platform; }
            set
            {
                platform = value;
                OnPropertyChanged(nameof(Platform));
            }
        }
        public int Category
        {
            get { return category; }
            set
            {
                category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
