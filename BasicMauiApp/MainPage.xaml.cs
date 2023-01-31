using Counter;

namespace BasicMauiApp
{
    public partial class MainPage : ContentPage
    {
        MyCounter _externalCounter;

        public MainPage()
        {
            InitializeComponent();

            _externalCounter = new MyCounter();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var count = _externalCounter.GetCount();
            _externalCounter.SetCount(count + 1);
            count = _externalCounter.GetCount();

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time (" + _externalCounter.GetDllName() + ")";
            else
                CounterBtn.Text = $"Clicked {count} times (" + _externalCounter.GetDllName() + ")";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}