using MauiAppMinhasCompras.Models; // Importa o modelo Produto.
using SQLite; // Importa SQLite para o banco de dados.

namespace MauiAppMinhasCompras.Helpers // Cria um espaço para helpers da aplicação.
{
    public class SQLiteDatabaseHelper // Classe para ajudar a gerenciar o banco de dados.
    {
        readonly SQLiteAsyncConnection _conn; // Conexão assíncrona com o banco de dados.

        public SQLiteDatabaseHelper(string path) // Construtor que recebe o caminho do banco de dados.
        {
            _conn = new SQLiteAsyncConnection(path); // Inicializa a conexão.
            _conn.CreateTableAsync<Produto>().Wait(); // Cria a tabela de produtos, se não existir.
        }

        public Task<int> Insert(Produto p) // Método para adicionar um produto.
        {
            return _conn.InsertAsync(p); // Insere o produto e retorna a tarefa.
        }

        public Task<List<Produto>> Update(Produto p) // Método para atualizar um produto.
        {
            string sql = "UPDATE Produto SET Descricao=?, Quantidade=?, Preco=? WHERE Id=?"; // SQL para atualizar.

            return _conn.QueryAsync<Produto>( // Executa a atualização.
                sql, p.Descricao, p.Quantidade, p.Preco, p.Id
            );
        }

        public Task<int> Delete(int id) // Método para remover um produto pelo ID.
        {
            return _conn.Table<Produto>().DeleteAsync(i => i.Id == id); // Deleta o produto.
        }

        public Task<List<Produto>> GetAll() // Método para obter todos os produtos.
        {
            return _conn.Table<Produto>().ToListAsync(); // Retorna a lista de produtos.
        }

        public Task<List<Produto>> Search(string q) // Método para buscar produtos por descrição.
        {
            string sql = "SELECT * FROM Produto WHERE descricao LIKE '%" + q + "%'"; // SQL para buscar.

            return _conn.QueryAsync<Produto>(sql); // Executa a busca e retorna os produtos encontrados.
        }
    }
}
