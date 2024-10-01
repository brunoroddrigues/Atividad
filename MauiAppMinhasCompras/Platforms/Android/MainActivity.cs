using Android.App; // Usado para atributos da aplicação Android.
using Android.Content.PM; // Usado para configurações de atividades.
using Android.OS; // Usado para funcionalidades do sistema Android.

namespace MauiAppMinhasCompras // Nome do espaço para a aplicação.
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)] // Define a tela inicial e como lidar com mudanças de configuração.
    public class MainActivity : MauiAppCompatActivity // Classe principal da atividade, herda de MauiAppCompatActivity.
    {
    }
}
