namespace Projet;

public partial class JobPage : ContentPage
{
	public JobPage()
	{
		InitializeComponent();
	}

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Jobs));
    }


}