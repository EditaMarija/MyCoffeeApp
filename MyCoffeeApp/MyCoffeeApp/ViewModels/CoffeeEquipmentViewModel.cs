using MvvmHelpers;
using MvvmHelpers.Commands;
using MyCoffeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Coffee> Coffee { get; set; }
        public ObservableRangeCollection<Grouping<string, Coffee>> CoffeeGroups { get; }

        public AsyncCommand RefreshCommand { get; }

        public CoffeeEquipmentViewModel()
        {
            Title = "Coffee Equipment";
            Coffee = new ObservableRangeCollection<Coffee>();
            CoffeeGroups = new ObservableRangeCollection<Grouping<string, Coffee>>();

            var image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSne2jiZ-0VRe7yChdyoLjTKED4am2n5GZYYg&usqp=CAU";
            Coffee.Add(new Coffee { Roaster = "Yes Plz", Name = "Sip of Sunshine", Image = image });
            Coffee.Add(new Coffee { Roaster = "Yes Plz", Name = "Potent Potable", Image = image });
            Coffee.Add(new Coffee { Roaster = "Blue Bottle", Name = "Kenya Kiambu Handege", Image = image });

            CoffeeGroups.Add(new Grouping<string, Coffee>("Blue Bottle", Coffee.Where(c => c.Roaster == "Blue Bottle")));
            CoffeeGroups.Add(new Grouping<string, Coffee>("Yes Plz", Coffee.Where(c => c.Roaster == "Yes Plz")));

        }

        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            IsBusy = false;
        }

        //public CoffeeEquipmentViewModel()
        //{
        //    IncreaseCount = new Command(OnIncrease);
        //}
        //public ICommand IncreaseCount { get; }

        //int count = 0;
        //string countDisplay = "Click me!";

        //public string CountDisplay
        //{
        //    get => countDisplay;
        //    set => SetProperty(ref countDisplay, value); 
        //set
        //{
        //    if (value == countDisplay)
        //        return;
        //    countDisplay = value;
        //    OnPropertyChanged();
        //}
        // }

        //void OnIncrease()
        //{
        //    count++;
        //    CountDisplay = $"You clicked {count} time(s)!";
        //}
    }
}
