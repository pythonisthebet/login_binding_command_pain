using login_binding_command_pain.Services;
using login_binding_command_pain.view_models;


namespace login_binding_command_pain;

public partial class Login : ContentPage
{
	public Login()
	{
        InitializeComponent();
        Login_Services service = new Login_Services();
        View_Model brain = new View_Model(service);
        BindingContext = brain;

        

    }


}