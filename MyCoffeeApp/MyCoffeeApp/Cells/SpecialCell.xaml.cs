﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpecialCell : ContentView
    {
        public SpecialCell()
        {
            InitializeComponent();
        }
    }
}