namespace Projet;

public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}
	private async void TapeGestureRecognize_Tapped_for_Login(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//LoginPage");
	}
}