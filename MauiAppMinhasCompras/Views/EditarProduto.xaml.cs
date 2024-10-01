using MauiAppMinhasCompras.Models; // Importa o modelo de produto.

namespace MauiAppMinhasCompras.Views; // Define o espa�o para a aplica��o.

public partial class EditarProduto : ContentPage // Classe que representa a p�gina de edi��o de produto.
{
    public EditarProduto() // Construtor da classe.
    {
        InitializeComponent(); // Inicializa os componentes da interface.
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e) // Evento para o bot�o "Salvar".
    {
        try
        {
            Produto produto_anexado = BindingContext as Produto; // Obt�m o produto associado � p�gina.

            Produto p = new Produto // Cria um novo objeto de produto com os dados da interface.
            {
                Id = produto_anexado.Id, // Mant�m o ID do produto existente.
                Descricao = txt_descricao.Text, // Obt�m a descri��o do campo de texto.
                Quantidade = Convert.ToDouble(txt_quantidade.Text), // Converte a quantidade para double.
                Preco = Convert.ToDouble(txt_preco.Text) // Converte o pre�o para double.
            };

            await App.Db.Update(p); // Atualiza o produto no banco de dados.
            await DisplayAlert("Sucesso!", "Registro Atualizado", "OK"); // Exibe mensagem de sucesso.
            await Navigation.PopAsync(); // Retorna � p�gina anterior.
        }
        catch (Exception ex) // Captura exce��es.
        {
            await DisplayAlert("Ops", ex.Message, "OK"); // Exibe uma mensagem de erro.
        }
    }
}
