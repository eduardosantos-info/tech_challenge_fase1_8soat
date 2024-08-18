namespace Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoItem { get; set; }
        public string DescricaoItem { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Valor { get; set; }
    }
}