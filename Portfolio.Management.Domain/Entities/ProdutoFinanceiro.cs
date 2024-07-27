namespace Portfolio.Management.Domain.Entities
{
    public class ProdutoFinanceiro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
