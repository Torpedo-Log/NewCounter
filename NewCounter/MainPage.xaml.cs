
using Microsoft.Maui.Storage;

namespace NewCounter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            int counterCount = Preferences.Get("CounterCount", 0);
            for (int i = 0; i < counterCount; i++)
            {
                var counterView = new CounterView();
                counterView.SetCounterName(Preferences.Get($"Counter_{i}_Name", $"Licznik {i + 1}"));
                counterView.SetCounterValue(Preferences.Get($"Counter_{i}_Value", 0));
                CounterList.Children.Add(counterView);
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Preferences.Set("CounterCount", CounterList.Children.Count);
            for (int i = 0; i < CounterList.Children.Count; i++)
            {
                if (CounterList.Children[i] is CounterView counterView)
                {
                    Preferences.Set($"Counter_{i}_Name", counterView.GetCounterName());
                    Preferences.Set($"Counter_{i}_Value", counterView.GetCounterValue());
                }
            }
        }

        private void OnAddCounterButtonClicked(object sender, EventArgs e)
        {

            var counterView = new CounterView();
            CounterList.Children.Add(counterView);
        }
    }
}
