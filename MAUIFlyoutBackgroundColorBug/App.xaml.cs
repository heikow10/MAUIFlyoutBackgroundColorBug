namespace MAUIFlyoutBackgroundColorBug
{
    public partial class App : Application
    {
        public App()
        {
            if (Current != null)
            {
                Current.UserAppTheme = AppTheme.Dark;
            }

            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}