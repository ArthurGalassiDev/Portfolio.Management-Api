namespace Portfolio.Management.Domain.Entities
{
    public class Investimento
    {
        public int Id { get; set; }
        public int ProdutoFinanceiroId { get; set; }
        public ProdutoFinanceiro ProdutoFinanceiro { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorInvestido { get; set; }
        public DateTime DataInvestimento { get; set; }
    }
}
