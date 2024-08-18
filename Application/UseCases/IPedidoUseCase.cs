using Domain.Entities;

namespace Application.UseCases;

public interface IPedidoUseCase
{
    void CriarPedido(Pedido pedido);
    void AtualizarStatusPedido(int id, StatusPedido novoStatus);
    Pedido ObterPorId(int id);
    List<Pedido> ObterTodos();
    void ExcluirPedido(int id);
    List<Pedido> ObterPorStatus(StatusPedido status);
}
