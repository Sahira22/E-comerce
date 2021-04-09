using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public int  GetProducts(){

            return 22;
        }

        [HttpGet("{id}")]
        public int  GetProduct(int id){

            return 1;
        }


    }
}