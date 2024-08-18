using Domain.Entities;

namespace Application.Repository;

public interface IPedidoRepository
{
    Pedido ObterPorId(int id);
    void Adicionar(Pedido pedido);
    void Atualizar(Pedido pedido);
    List<Pedido> ObterTodos();
    void Excluir(int id);
    List<Pedido> ObterPorStatus(StatusPedido status);
}
