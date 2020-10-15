using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TheDecider
{
    public partial class DecisionPage : ContentPage
    {
        public DecisionPage(string decision)
        {
            InitializeComponent();
            Decision.Text = decision;
        }
    }
}
