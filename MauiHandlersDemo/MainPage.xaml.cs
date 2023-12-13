using MauiHandlersDemo.ViewModels;

namespace MauiHandlersDemo
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _mainViewModel;

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;
            BindingContext = _mainViewModel;
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            drawCanvas.Clear();
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            drawCanvas.Save();
        }
    }

}
