using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDecider.Models;
using Xamarin.Forms;

namespace TheDecider
{
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Choice> choices = new ObservableCollection<Choice>();
        public ObservableCollection<Choice> Choices { get { return choices; } }
        Random random = new Random();

        public MainPage()
        { 
            InitializeComponent();
            ChoicesView.ItemsSource = Choices;
        }

        private void AddChoice(object sender, EventArgs e)
        {

            if (choice.Text.Trim() != "")
            {
                choices.Add(new Choice { choice = choice.Text });
                choice.Text = "";
            }
            

        }

        
        private async void GetResult(object sender, EventArgs e)
        {
            if (Choices.Count > 0)
            {
                int num = random.Next(Choices.Count);
                //result.Text = Choices[num].choice;
                await Navigation.PushAsync(new DecisionPage(Choices[num].choice));
            }
           

        }

    }
}
