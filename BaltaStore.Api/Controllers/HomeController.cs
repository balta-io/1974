using Microsoft.AspNetCore.Mvc;

namespace BaltaStore.Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        // [Route("clientes")] // Listar todos os clientes
        // [Route("clientes/2587")] // Listar o cliente 2587
        // [Route("clientes/2587/pedidos")] // Pedidos do cliente 2587
        public object Get()
        {
            return new { version = "Version 0.0.1" };
        }
    }
}