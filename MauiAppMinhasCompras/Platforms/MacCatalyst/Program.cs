using ObjCRuntime; // Usado para funcionalidades de runtime do Objective-C.
using UIKit; // Usado para a interface gráfica do iOS.

namespace MauiAppMinhasCompras // Nome do espaço para a aplicação.
{
    public class Program // Classe principal da aplicação.
    {
        // Este é o ponto de entrada principal da aplicação.
        static void Main(string[] args) // Método principal que inicia a aplicação.
        {
            // Se você quiser usar uma classe de delegado de aplicação diferente de "AppDelegate"
            // você pode especificá-la aqui.
            UIApplication.Main(args, null, typeof(AppDelegate)); // Inicia a aplicação com o AppDelegate.
        }
    }
}
