
namespace NewCounter
{
    public partial class CounterView : ContentView
    {
        private int counter = 0;

        public CounterView()
        {
            InitializeComponent();
        }

        public void SetCounterName(string name)
        {
            CounterName.Text = name;
        }

        public string GetCounterName()
        {
            return CounterName.Text;
        }

        public void SetCounterValue(int value)
        {
            counter = value;
            CounterLabel.Text = counter.ToString();
        }

        public int GetCounterValue()
        {
            return counter;
        }

        private void OnIncrementButtonClicked(object sender, EventArgs e)
        {
            counter++;
            CounterLabel.Text = counter.ToString();
        }

        private void OnDecrementButtonClicked(object sender, EventArgs e)
        {
            counter--;
            CounterLabel.Text = counter.ToString();
        }
    }
}
