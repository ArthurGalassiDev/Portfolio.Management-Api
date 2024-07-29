using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Management.Domain.Entities
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public int ProdutoFinanceiroId { get; set; }

        [Required]
        public DateTime DataTransacao { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required]
        public bool Compra { get; set; } // true para compra, false para venda

        [ForeignKey(nameof(ClienteId))]
        public Cliente Cliente { get; set; }

        [ForeignKey(nameof(ProdutoFinanceiroId))]
        public ProdutoFinanceiro ProdutoFinanceiro { get; set; }
    }
}
