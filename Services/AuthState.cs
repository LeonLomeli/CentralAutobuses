namespace CentralAutobuses.Services;

public interface IAuthState
{
    bool IsLoggedIn { get; }
    event Action? OnChange;
    void Login();
    void Logout();
}

public class AuthState : IAuthState
{
    public bool IsLoggedIn { get; private set; } = false;

    public event Action? OnChange;

    public void Login()
    {
        IsLoggedIn = true;
        OnChange?.Invoke();
    }

    public void Logout()
    {
        IsLoggedIn = false;
        OnChange?.Invoke();
    }
}