using CentralAutobuses.Services;
using Microsoft.AspNetCore.Components;

namespace CentralAutobuses.Components.Pages;

public partial class Login
{
    [Inject]
    private IAuthState AuthState { get; set; } = default!;

    [Inject]
    private NavigationManager NavManager { get; set; } = default!;

    private string user = "";
    private string password = "";
    private string message = "";

    private void IntentarLogin()
    {
        if (user == "admin" && password == "1234")
        {
            AuthState.Login();
            NavManager.NavigateTo("/");
        }
        else
        {
            message = "Usuario o contraseña incorrectos";
        }
    }
}