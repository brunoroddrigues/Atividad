using SQLite; // Importa o namespace para usar SQLite como banco de dados.

namespace MauiAppMinhasCompras.Models // Define um namespace para organizar os modelos da aplicação.
{
    public class Produto // Define a classe Produto que representa um item de compra.
    {
        string _descricao; // Declara uma variável privada para armazenar a descrição do produto.

        [PrimaryKey, AutoIncrement] // Indica que Id é a chave primária e deve ser incrementada automaticamente.
        public int Id { get; set; } // Propriedade pública para o identificador do produto.

        public string Descricao
        { // Propriedade pública para a descrição do produto.
            get => _descricao; // Retorna o valor da descrição.
            set // Define o valor da descrição.
            {
                if (value == null) // Verifica se o valor fornecido é nulo.
                {
                    throw new Exception("Por favor, preencha a descrição"); // Lança uma exceção se a descrição estiver vazia.
                }

                _descricao = value; // Atribui o valor à variável privada _descricao.
            }
        }

        public double Quantidade { get; set; } // Propriedade pública para a quantidade do produto.
        public double Preco { get; set; } // Propriedade pública para o preço do produto.

        public double Total { get => Quantidade * Preco; } // Propriedade somente leitura que calcula o total (quantidade * preço).
    }
}
