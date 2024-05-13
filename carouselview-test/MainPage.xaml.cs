namespace carouselview_test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IEnumerable<object> items = [string.Empty];
            carousel.ItemsSource = items;
        }

        private void Grid_SizeChanged(object sender, EventArgs e)
        {
            var grid = (Grid)sender;
            Console.WriteLine($"Grid size changed to {grid.Width} width and {grid.Height} height");
        }
    }

}
