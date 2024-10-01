using MauiAppMinhasCompras.Models; // Importa o modelo de produto.

namespace MauiAppMinhasCompras.Views; // Define o espaço para a aplicação.

public partial class EditarProduto : ContentPage // Classe que representa a página de edição de produto.
{
    public EditarProduto() // Construtor da classe.
    {
        InitializeComponent(); // Inicializa os componentes da interface.
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e) // Evento para o botão "Salvar".
    {
        try
        {
            Produto produto_anexado = BindingContext as Produto; // Obtém o produto associado à página.

            Produto p = new Produto // Cria um novo objeto de produto com os dados da interface.
            {
                Id = produto_anexado.Id, // Mantém o ID do produto existente.
                Descricao = txt_descricao.Text, // Obtém a descrição do campo de texto.
                Quantidade = Convert.ToDouble(txt_quantidade.Text), // Converte a quantidade para double.
                Preco = Convert.ToDouble(txt_preco.Text) // Converte o preço para double.
            };

            await App.Db.Update(p); // Atualiza o produto no banco de dados.
            await DisplayAlert("Sucesso!", "Registro Atualizado", "OK"); // Exibe mensagem de sucesso.
            await Navigation.PopAsync(); // Retorna à página anterior.
        }
        catch (Exception ex) // Captura exceções.
        {
            await DisplayAlert("Ops", ex.Message, "OK"); // Exibe uma mensagem de erro.
        }
    }
}
