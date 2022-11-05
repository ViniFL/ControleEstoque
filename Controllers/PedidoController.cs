using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControleEstoque.Models;

namespace ControleEstoque.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private static List<Pedido> Pedidos()
        {
            return new List<Pedido>
            {
                new Pedido{ NumeroProduto = 5, QuantidadeProduto = 3, ValorProduto = 2.50 }
            };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Pedidos());
        }
        [HttpPost]
        public IActionResult Post(Pedido pedido)
        {
            var pedidos = Pedidos();
            pedidos.Add(pedido);
            return Ok(pedidos);
        }
}
}
