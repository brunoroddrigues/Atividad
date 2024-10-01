using Microsoft.Maui; // Usado para funcionalidades da plataforma Maui.
using Microsoft.Maui.Hosting; // Usado para o ambiente de hospedagem da aplicação Maui.
using System; // Importa funcionalidades básicas do .NET.

namespace MauiAppMinhasCompras // Nome do espaço para a aplicação.
{
    internal class Program : MauiApplication // Classe principal da aplicação, herda de MauiApplication.
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(); // Método que cria a aplicação Maui.

        static void Main(string[] args) // Método principal que inicia a aplicação.
        {
            var app = new Program(); // Cria uma nova instância da aplicação.
            app.Run(args); // Executa a aplicação com os argumentos fornecidos.
        }
    }
}
