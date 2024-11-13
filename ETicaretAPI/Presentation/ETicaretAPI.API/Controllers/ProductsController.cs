using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //çoğul isimlendirme yapılır
    public class ProductsController : ControllerBase
    {
        public IActionResult GetProducs()
        {
            return Ok();
        }
    }
}
