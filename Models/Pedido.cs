using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEstoque.Models
{
    public class Pedidos
    {
        [Key]
        public int NumeroProduto { get; set; }
        public Guid CodigoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public decimal ValorProduto { get; set; }
    }
}