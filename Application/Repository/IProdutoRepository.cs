using Domain.Entities;

namespace Application.Repository;

public interface IProdutoRepository
{
    Produto ObterPorId(int id);
    void Adicionar(Produto produto);
    void Atualizar(Produto produto);
    List<Produto> ObterTodos();
    void Excluir(int id);
    List<Produto> ObterPorCategoria(Categoria categoria);
}