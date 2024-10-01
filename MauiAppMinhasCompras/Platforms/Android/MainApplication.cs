using Android.App; // Usado para atributos da aplicação Android.
using Android.Runtime; // Usado para funcionalidades relacionadas ao runtime do Android.

namespace MauiAppMinhasCompras // Nome do espaço para a aplicação.
{
    [Application] // Define a classe como uma aplicação Android.
    public class MainApplication : MauiApplication // Classe principal da aplicação, herda de MauiApplication.
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership) // Construtor que recebe o ponteiro e a propriedade do Jni.
            : base(handle, ownership) // Chama o construtor da classe base.
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(); // Método que cria a aplicação Maui.
    }
}
