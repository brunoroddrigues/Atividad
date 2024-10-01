using Foundation; // Usado para funcionalidades básicas da aplicação iOS.

namespace MauiAppMinhasCompras // Nome do espaço para a aplicação.
{
    [Register("AppDelegate")] // Define a classe como o AppDelegate da aplicação iOS.
    public class AppDelegate : MauiUIApplicationDelegate // Classe que herda de MauiUIApplicationDelegate.
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(); // Método que cria a aplicação Maui.
    }
}
