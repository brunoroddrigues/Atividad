using Microsoft.Maui; // Usado para funcionalidades da plataforma Maui.
using Microsoft.Maui.Hosting; // Usado para o ambiente de hospedagem da aplica��o Maui.
using System; // Importa funcionalidades b�sicas do .NET.

namespace MauiAppMinhasCompras // Nome do espa�o para a aplica��o.
{
    internal class Program : MauiApplication // Classe principal da aplica��o, herda de MauiApplication.
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(); // M�todo que cria a aplica��o Maui.

        static void Main(string[] args) // M�todo principal que inicia a aplica��o.
        {
            var app = new Program(); // Cria uma nova inst�ncia da aplica��o.
            app.Run(args); // Executa a aplica��o com os argumentos fornecidos.
        }
    }
}
