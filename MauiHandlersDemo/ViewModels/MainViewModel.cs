using CommunityToolkit.Mvvm.ComponentModel;
using MauiHandlersDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<TextColorModel> MyColors { get; set; } = new();

        [ObservableProperty]
        TextColorModel selectedColor;

        public MainViewModel()
        {
            PopulateColorsList();
            
        }

        private void PopulateColorsList()
        {
            MyColors.Add(new()
            {
                TextColor = Colors.Red,
                Name = "Red"
            });

            MyColors.Add(new()
            {
                TextColor = Colors.Green,
                Name = "Green"
            });

            MyColors.Add(new()
            {
                TextColor = Colors.Blue,
                Name = "Blue"
            });

            MyColors.Add(new()
            {
                TextColor = Colors.Yellow,
                Name = "Yellow"
            });

            MyColors.Add(new()
            {
                TextColor = Colors.Orange,
                Name = "Orange"
            });

            MyColors.Add(new()
            {
                TextColor = Colors.Magenta,
                Name = "Magenta"
            });
        }
    }
}
