namespace mchicaizaS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //navegacion
            return new Window(new NavigationPage (new Views.vista1()));
        }
    }
}