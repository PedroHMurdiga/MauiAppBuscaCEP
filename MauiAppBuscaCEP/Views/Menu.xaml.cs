namespace MauiAppBuscaCEP.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(
            new Views.BuscaCepPorLogradouro());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.BairrosPorCidade());
    }
}