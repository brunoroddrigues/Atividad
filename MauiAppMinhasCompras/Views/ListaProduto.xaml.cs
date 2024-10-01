using MauiAppMinhasCompras.Models; // Importa o modelo de produto.
using System.Collections.ObjectModel; // Usado para cole��es que notificam mudan�as.

namespace MauiAppMinhasCompras.Views; // Define o espa�o para a aplica��o.

public partial class ListaProduto : ContentPage // Classe que representa a p�gina de lista de produtos.
{
    ObservableCollection<Produto> lista = new ObservableCollection<Produto>(); // Cole��o observ�vel para armazenar produtos.

    public ListaProduto() // Construtor da classe.
    {
        InitializeComponent(); // Inicializa os componentes da interface.

        lst_produtos.ItemsSource = lista; // Define a fonte de itens da lista como a cole��o de produtos.
    }

    protected async override void OnAppearing() // M�todo chamado quando a p�gina aparece.
    {
        try
        {
            lista.Clear(); // Limpa a lista de produtos.

            List<Produto> tmp = await App.Db.GetAll(); // Busca todos os produtos do banco de dados.

            tmp.ForEach(i => lista.Add(i)); // Adiciona os produtos encontrados � lista.
        }
        catch (Exception ex) // Captura exce��es.
        {
            await DisplayAlert("Ops", ex.Message, "OK"); // Exibe uma mensagem de erro.
        }
    }

    private void ToolbarItem_Clicked(object sender, EventArgs e) // Evento para o bot�o "Adicionar".
    {
        try
        {
            Navigation.PushAsync(new Views.NovoProduto()); // Navega para a p�gina de novo produto.
        }
        catch (Exception ex) // Captura exce��es.
        {
            DisplayAlert("Ops", ex.Message, "OK"); // Exibe uma mensagem de erro.
        }
    }

    private async void txt_search_TextChanged(object sender, TextChangedEventArgs e) // Evento para busca de produtos.
    {
        try
        {
            string q = e.NewTextValue; // Obt�m o texto da busca.

            lista.Clear(); // Limpa a lista de produtos.

            List<Produto> tmp = await App.Db.Search(q); // Busca produtos com base no texto.

            tmp.ForEach(i => lista.Add(i)); // Adiciona os produtos encontrados � lista.
        }
        catch (Exception ex) // Captura exce��es.
        {
            await DisplayAlert("Ops", ex.Message, "OK"); // Exibe uma mensagem de erro.
        }
    }

    private void ToolbarItem_Clicked_1(object sender, EventArgs e) // Evento para o bot�o "Somar".
    {
        double soma = lista.Sum(i => i.Total); // Calcula o total dos produtos.

        string msg = $"O total � {soma:C}"; // Formata a mensagem com o total.

        DisplayAlert("Total dos Produtos", msg, "OK"); // Exibe o total em um alerta.
    }

    private async void MenuItem_Clicked(object sender, EventArgs e) // Evento para remover um produto.
    {
        try
        {
            MenuItem selecinado = sender as MenuItem; // Obt�m o item selecionado do menu.

            Produto p = selecinado.BindingContext as Produto; // Obt�m o produto associado ao item.

            bool confirm = await DisplayAlert( // Pergunta para confirmar a remo��o.
                "Tem Certeza?", $"Remover {p.Descricao}?", "Sim", "N�o");

            if (confirm) // Se confirmado, remove o produto.
            {
                await App.Db.Delete(p.Id); // Remove do banco de dados.
                lista.Remove(p); // Remove da lista.
            }
        }
        catch (Exception ex) // Captura exce��es.
        {
            await DisplayAlert("Ops", ex.Message, "OK"); // Exibe uma mensagem de erro.
        }
    }

    private void lst_produtos_ItemSelected(object sender, SelectedItemChangedEventArgs e) // Evento quando um item � selecionado.
    {
        try
        {
            Produto p = e.SelectedItem as Produto; // Obt�m o produto selecionado.

            Navigation.PushAsync(new Views.EditarProduto // Navega para a p�gina de editar produto.
            {
                BindingContext = p, // Define o contexto de dados como o produto selecionado.
            });
        }
        catch (Exception ex) // Captura exce��es.
        {
            DisplayAlert("Ops", ex.Message, "OK"); // Exibe uma mensagem de erro.
        }
    }
}
