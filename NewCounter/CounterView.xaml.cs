namespace NewCounter
{
    public partial class CounterView : ContentView
    {
        private int counter = 0;
        private Editor btnValue;

        public CounterView()
        {
            InitializeComponent();
        }

        public string GetCounterName()
        {
            return CounterName.Text;
        }

        public void SetCounterName(string name)
        {
            CounterName.Text = name;
        }

        public int GetCounterValue()
        {
            return counter;
        }

        public void SetCounterValue(int value)
        {
            counter = value;
            CounterLabel.Text = counter.ToString();
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
