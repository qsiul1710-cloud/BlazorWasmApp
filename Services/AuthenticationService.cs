using System.Text.Json;
using Microsoft.JSInterop;

namespace BlazorWasmApp.Services
{
    /// <summary>
    /// Servicio de autenticación que maneja el login y logout de usuarios.
    /// </summary>
    public class AuthenticationService
    {
        private const string AuthStorageKey = "auth_user";
        private readonly IJSRuntime _jsRuntime;

        /// <summary>
        /// Usuario actualmente autenticado. Null si no hay usuario autenticado.
        /// </summary>
        public User? CurrentUser { get; private set; }

        /// <summary>
        /// Indica si hay un usuario autenticado en la sesión.
        /// </summary>
        public bool IsAuthenticated => CurrentUser != null;

        /// <summary>
        /// Evento que se dispara cuando cambia el estado de autenticación.
        /// </summary>
        public event Action? OnAuthenticationStateChanged;

        /// <summary>
        /// Credenciales hardcodeadas de demostración.
        /// En producción, esto vendría de una API segura.
        /// </summary>
        private readonly Dictionary<string, string> _validCredentials = new()
        {
            { "admin", "admin123" },
            { "usuario", "password123" }
        };

        /// <summary>
        /// Constructor que inyecta IJSRuntime para acceder a localStorage.
        /// </summary>
        public AuthenticationService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        /// <summary>
        /// Inicializa el servicio cargando el usuario desde localStorage si existe.
        /// Debe llamarse cuando la aplicación inicia.
        /// </summary>
        public async Task InitializeAsync()
        {
            try
            {
                var userJson = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", AuthStorageKey);
                if (!string.IsNullOrEmpty(userJson))
                {
                    CurrentUser = JsonSerializer.Deserialize<User>(userJson);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading auth state: {ex.Message}");
            }
        }

        /// <summary>
        /// Intenta autenticar un usuario con sus credenciales.
        /// </summary>
        /// <param name="username">Nombre de usuario</param>
        /// <param name="password">Contraseña</param>
        /// <returns>True si la autenticación fue exitosa, false en caso contrario</returns>
        public async Task<bool> LoginAsync(string username, string password)
        {
            // Simular latencia de red
            await Task.Delay(500);

            // Validar credenciales
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            if (_validCredentials.TryGetValue(username, out var storedPassword))
            {
                if (storedPassword == password)
                {
                    // Login exitoso
                    CurrentUser = new User
                    {
                        Id = 1,
                        Username = username,
                        FullName = GetFullNameFromUsername(username),
                        LoginTime = DateTime.Now
                    };

                    // Guardar en localStorage
                    try
                    {
                        var userJson = JsonSerializer.Serialize(CurrentUser);
                        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", AuthStorageKey, userJson);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error saving auth state: {ex.Message}");
                    }

                    // Notificar cambio de estado
                    OnAuthenticationStateChanged?.Invoke();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Cierra la sesión del usuario actualmente autenticado.
        /// </summary>
        public async Task LogoutAsync()
        {
            // Simular latencia de red
            await Task.Delay(300);

            CurrentUser = null;

            // Eliminar de localStorage
            try
            {
                await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", AuthStorageKey);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error removing auth state: {ex.Message}");
            }

            OnAuthenticationStateChanged?.Invoke();
        }

        /// <summary>
        /// Obtiene el nombre completo basado en el nombre de usuario.
        /// </summary>
        private string GetFullNameFromUsername(string username)
        {
            return username.ToLower() switch
            {
                "admin" => "Administrador",
                "usuario" => "Usuario Demo",
                _ => username
            };
        }
    }

    /// <summary>
    /// Representa un usuario autenticado en el sistema.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identificador único del usuario.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de usuario para login.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Nombre completo del usuario.
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Fecha y hora de login.
        /// </summary>
        public DateTime LoginTime { get; set; }
    }
}
