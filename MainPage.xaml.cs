namespace TARpe24_Mobiilirakendused
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                CounterBtn.Text = $"Clicked {count} time";
            }

            else if (count >= 10)
            {
                botImage.IsVisible = false;
                CounterBtn.Text = "Pilt kadus ära! Vajuta reset.";
            }
  
            else
            {
                CounterBtn.Text = $"Clicked {count} times";
                botImage.Rotation += 100;

                var rnd = new Random();
                var rndColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                BackgroundColor = rndColor;
                SemanticScreenReader.Announce(CounterBtn.Text);
            }

        }

        private void ResetBtn_Clicked(object sender, EventArgs e)
        {
            count = 0;
            CounterBtn.Text = "Alustame uuesti!";
            botImage.Rotation = 0;
        }
    }
}
