using CentralAutobuses.Services;
using Microsoft.AspNetCore.Components;

namespace CentralAutobuses.Components.Layout;

public partial class NavMenu
{
    [Inject]
    private IAuthState AuthState { get; set; } = default!;

    [Inject]
    private NavigationManager NavManager { get; set; } = default!;

    private void CerrarSesion()
    {
        AuthState.Logout();
        NavManager.NavigateTo("/login");
    }
}
