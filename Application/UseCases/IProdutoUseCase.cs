using Domain.Entities;

namespace Application.UseCases;

public interface IProdutoUseCase
{
    void CriarProduto(Produto produto);
    void AtualizarProduto(Produto produto);
    void ExcluirProduto(int id);
    Produto ObterPorId(int id);
    List<Produto> ObterTodos();
    List<Produto> ObterPorCategoria(Categoria categoria);
}