using System.Text.Json;
using CasaEcologie.WinForms.Formulaires;

namespace CasaEcologie.WinForms;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var configPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        var configJson = File.ReadAllText(configPath);
        var config = JsonDocument.Parse(configJson);
        var connectionString = config.RootElement
            .GetProperty("ConnectionStrings")
            .GetProperty("CasaDB")
            .GetString()!;

        var services = new ServiceContainer(connectionString);

        using var loginForm = new FrmConnexion(services);
        Application.Run(loginForm);
    }
}
