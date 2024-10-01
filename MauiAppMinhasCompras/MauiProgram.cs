using Microsoft.Extensions.Logging; // Importa o namespace para registrar logs.

namespace MauiAppMinhasCompras // Define um namespace para organizar o código da aplicação.
{
    public static class MauiProgram // Define uma classe estática chamada MauiProgram.
    {
        public static MauiApp CreateMauiApp() // Método público que cria e configura a aplicação Maui.
        {
            var builder = MauiApp.CreateBuilder(); // Cria um construtor para a aplicação Maui.
            builder
                .UseMauiApp<App>() // Define a classe App como a aplicação principal.
                .ConfigureFonts(fonts => // Configura as fontes utilizadas na aplicação.
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); // Adiciona a fonte regular.
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold"); // Adiciona a fonte semibold.
                });

#if DEBUG // Verifica se o código está em modo de depuração.
            builder.Logging.AddDebug(); // Adiciona um logger para saída de depuração.
#endif

            return builder.Build(); // Constrói e retorna a aplicação configurada.
        }
    }
}
