
namespace WhatsRedirect
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

#if WINDOWS
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.MaximumWidth = 400;

            window.Height = 330;
            window.MaximumHeight = 330;

            return window;
        }
#endif

    }
}
