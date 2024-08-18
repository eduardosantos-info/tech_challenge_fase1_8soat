using Application.Repository;
using Domain.Entities;

namespace Infra.Repository;

public class ProdutoRepository : IProdutoRepository
{
    private readonly List<Produto> _produtos = new List<Produto>();
    public void Adicionar(Produto produto)
    {
        produto.Id = _produtos.Count + 1;
        _produtos.Add(produto);
    }

    public void Atualizar(Produto produto)
    {
        var produtoExistente = ObterPorId(produto.Id);
        if (produtoExistente != null)
        {
            _produtos.Remove(produtoExistente);
            _produtos.Add(produto);
        }
    }

    public void Excluir(int id)
    {
        var produto = ObterPorId(id);
        _produtos.Remove(produto);
    }

    public List<Produto> ObterPorCategoria(Categoria categoria)
    {
        return _produtos.Where(c => c.Categoria == categoria).ToList();
    }

    public Produto ObterPorId(int id)
    {
        return _produtos.Single(c => c.Id == id);
    }

    public List<Produto> ObterTodos()
    {
        return _produtos;
    }
}
