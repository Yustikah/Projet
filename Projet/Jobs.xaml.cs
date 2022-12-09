using Projet.Model;

namespace Projet;

public partial class Jobs : ContentPage
{

    JobsModel jobsModel;

    public Jobs()
	{
		InitializeComponent();
        jobsModel = new JobsModel();
        BindingContext = jobsModel;
	}

    
}