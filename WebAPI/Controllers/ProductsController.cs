using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFremwork;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely Coupled--zayıf bağlılık soyuta bağlılık
        //IoS Container -- Inversion of Control  belleğe atıp ihtiyaç halinde kullandırma
        IProductServis _productServis;

        public ProductsController(IProductServis productServis)
        {
            _productServis = productServis;
        }

        [HttpGet("getall")]//ürünleri gösterme
        public IActionResult Get()
        {
            var result = _productServis.GetAll();
            //Dependency chain- bağımlılık zinciri  p.servise p.manager barındırdığından bu şekilde yazık ayrıca p.servis p.managere ihtiyaç duyuyo p.manager p.dala ihtiyaç duyuyo 
            // IProductServis productServis = new ProductManager(new EfProductDal());
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyıd")]
        public IActionResult Get(int id)
        {
            var result =_productServis.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);




        }

        [HttpPost("add")]//ürünleri ekleme
        public IActionResult Add(Product product)
        {
            var result = _productServis.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
