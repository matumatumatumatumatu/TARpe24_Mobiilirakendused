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
            botImage.Opacity -= 0.1;
            botImage.Scale += 0.1;
            if (count == 1)
            {
                
                CounterBtn.Text = $"Clicked {count} time";
            }
            else if (count >= 10)
            {
                botImage.IsVisible = false;
                CounterBtn.Text = "Pilt kadus ära! Vajuta reset.";
            }

            else if(count >= 5)
            {
                CounterBtn.Text = $"Clicked {count} times";
                CounterBtn.BackgroundColor = Colors.Red;
                CounterBtn.TextColor = Colors.White;
                botImage.Rotation += 100;
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
            botImage.Opacity = 1;
            botImage.Scale = 1;
            CounterBtn.BackgroundColor = Colors.Purple;
            botImage.IsVisible = true;
            count = 0;
            CounterBtn.Text = "Alustame uuesti!";
            botImage.Rotation = 0;

            if (botImage.HorizontalOptions == LayoutOptions.Start)
            {
                botImage.HorizontalOptions = LayoutOptions.End;
            }
            else
            {
                botImage.HorizontalOptions = LayoutOptions.Start;
            }
        }
    }
}
