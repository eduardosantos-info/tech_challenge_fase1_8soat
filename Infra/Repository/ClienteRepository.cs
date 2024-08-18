using Application.Repository;
using Domain.Entities;

namespace Infra.Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly List<Cliente> _cliente = new List<Cliente>();
    public void Adicionar(Cliente cliente)
    {
        cliente.Id = _cliente.Count + 1;
        _cliente.Add(cliente);
    }

    public void Atualizar(Cliente cliente)
    {
        var clienteExistente = ObterPorId(cliente.Id);
        if (clienteExistente != null)
        {
            _cliente.Remove(clienteExistente);
            _cliente.Add(cliente);
        }
    }

    public void Excluir(int id)
    {
        var cliente = ObterPorId(id);
        _cliente.Remove(cliente);
    }

    public Cliente ObterPorCpf(string cpf)
    {
        return _cliente.Single(c => c.Cpf == cpf);
    }

    public Cliente ObterPorId(int id)
    {
        return _cliente.Single(c => c.Id == id);
    }

    public List<Cliente> ObterTodos()
    {
        return _cliente;
    }
}
