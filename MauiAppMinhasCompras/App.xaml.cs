using MauiAppMinhasCompras.Helpers; // Importa o namespace para acessar helpers da aplicação.

namespace MauiAppMinhasCompras // Define um namespace para a aplicação principal.
{
    public partial class App : Application // Define a classe App que herda de Application.
    {
        static SQLiteDatabaseHelper _db; // Declara uma variável estática para o helper do banco de dados.

        public static SQLiteDatabaseHelper Db // Propriedade pública para acessar o banco de dados.
        {
            get // Método getter para a propriedade.
            {
                if (_db == null) // Verifica se o banco de dados ainda não foi inicializado.
                {
                    string path = Path.Combine( // Define o caminho do banco de dados.
                        Environment.GetFolderPath( // Obtém o caminho do diretório de dados da aplicação.
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3"); // Nome do arquivo do banco de dados.

                    _db = new SQLiteDatabaseHelper(path); // Inicializa o helper do banco de dados com o caminho.
                }

                return _db; // Retorna a instância do helper do banco de dados.
            }
        }

        public App() // Construtor da classe App.
        {
            InitializeComponent(); // Inicializa os componentes da aplicação.

            //MainPage = new AppShell(); // Define a página principal como AppShell (comentado).
            MainPage = new NavigationPage(new Views.ListaProduto()); // Define a página principal como uma NavigationPage que exibe a lista de produtos.
        }
    }
}
