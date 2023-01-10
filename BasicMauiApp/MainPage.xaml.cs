﻿namespace BasicMauiApp
{
    public partial class MainPage : ContentPage
    {
        Counter.Counter _externalCounter;

        public MainPage()
        {
            InitializeComponent();

            _externalCounter = new Counter.Counter();
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