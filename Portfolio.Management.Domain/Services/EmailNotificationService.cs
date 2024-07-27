using Portfolio.Management.Domain.Entities;

namespace Portfolio.Management.Domain.Services
{
    public class EmailNotificationService
    {
        public void EnviarNotificacoesDeVencimento(IEnumerable<ProdutoFinanceiro> produtos)
        {
            var produtosVencendo = produtos.Where(p => p.DataVencimento <= DateTime.Now.AddDays(7));

            foreach (var produto in produtosVencendo)
            {
                // Simulação do envio de e-mail
                Console.WriteLine($"Enviando e-mail: O produto {produto.Nome} está vencendo em {produto.DataVencimento}");
            }
        }
    }
}
