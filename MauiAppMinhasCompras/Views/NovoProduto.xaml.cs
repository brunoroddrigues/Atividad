using MauiAppMinhasCompras.Models; // Importa o modelo de produto.

namespace MauiAppMinhasCompras.Views; // Define o espaço para a aplicação.

public partial class NovoProduto : ContentPage // Classe que representa a página para adicionar um novo produto.
{
    public NovoProduto() // Construtor da classe.
    {
        InitializeComponent(); // Inicializa os componentes da interface.
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e) // Evento para o botão "Salvar".
    {
        try
        {
            Produto p = new Produto // Cria um novo objeto de produto com os dados da interface.
            {
                Descricao = txt_descricao.Text, // Obtém a descrição do campo de texto.
                Quantidade = Convert.ToDouble(txt_quantidade.Text), // Converte a quantidade para double.
                Preco = Convert.ToDouble(txt_preco.Text) // Converte o preço para double.
            };

            await App.Db.Insert(p); // Insere o novo produto no banco de dados.
            await DisplayAlert("Sucesso!", "Registro Inserido", "OK"); // Exibe mensagem de sucesso.
        }
        catch (Exception ex) // Captura exceções.
        {
            await DisplayAlert("Ops", ex.Message, "OK"); // Exibe uma mensagem de erro.
        }
    }
}
