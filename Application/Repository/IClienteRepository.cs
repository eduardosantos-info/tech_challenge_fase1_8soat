using Domain.Entities;

namespace Application.Repository;

public interface IClienteRepository
{
    Cliente ObterPorId(int id);
    void Adicionar(Cliente cliente);
    void Atualizar(Cliente cliente);
    void Excluir(int id);
    List<Cliente> ObterTodos();
    Cliente ObterPorCpf(string cpf);
}
