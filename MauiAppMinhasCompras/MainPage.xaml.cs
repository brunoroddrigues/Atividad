namespace MauiAppMinhasCompras // Nome do espaço para a aplicação.
{
    public partial class MainPage : ContentPage // Classe que representa a página principal, herda de ContentPage.
    {
        int count = 0; // Contador para rastrear quantas vezes o botão foi clicado.

        public MainPage() // Construtor da MainPage.
        {
            InitializeComponent(); // Inicializa os componentes da interface.
        }

        private void OnCounterClicked(object sender, EventArgs e) // Método chamado quando o botão é clicado.
        {
            count++; // Incrementa o contador.

            if (count == 1) // Verifica se é o primeiro clique.
                CounterBtn.Text = $"Clicked {count} time"; // Atualiza o texto para singular.
            else
                CounterBtn.Text = $"Clicked {count} times"; // Atualiza o texto para plural.

            SemanticScreenReader.Announce(CounterBtn.Text); // Anuncia o texto atualizado para leitores de tela.
        }
    }
}
