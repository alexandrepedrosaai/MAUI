namespace MauiApp1.Pages;

public partial class BenchmarkDashboardPage : ContentPage
{
    public BenchmarkDashboardPage()
    {
        InitializeComponent();
        BindingContext = new MauiApp1.PageModels.BenchmarkDashboardPageModel();
    }
}
