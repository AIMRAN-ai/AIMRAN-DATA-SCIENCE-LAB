namespace AIMRAN_Data_Science_Lab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "AIMRAN Data Science Lab" };
        }
    }
}
