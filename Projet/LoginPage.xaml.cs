namespace Projet;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private async void TapeGestureRecognize_Tapped_for_Registration(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Registration");
    }
}