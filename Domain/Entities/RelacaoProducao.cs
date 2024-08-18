namespace Domain.Entities;

public class RelacaoProducao
{
    public int Id { get; set; }
    public Produto Produto { get; set; }
    public List<Ingrediente> Ingredientes { get; set; }
}