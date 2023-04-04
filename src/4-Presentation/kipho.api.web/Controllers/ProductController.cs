using kipho.api.domain.Entities;
using kipho.api.domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace kipho.api.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductsServices _productsServices;
        public ProductController(IProductsServices productsServices)
        {
            _productsServices = productsServices;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _productsServices.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _productsServices.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("{barCode}")]
        public async Task<ActionResult> GetbyBarcode(string barCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _productsServices.GetbyBarcode(barCode));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] List<Products> user) 
        {
            var countYes = 0;
            var countNot = 0;
            List<Products> produvtsWithDefects = new List<Products>();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                for (int i=0; i < user.Count; i++) 
                {
                    var result = await _productsServices.Post(user[i]);
                    if (result != null)
                    {
                        countYes++;
                    }
                    else 
                    {
                        countNot++;
                        produvtsWithDefects.Add(user[i]);
                    }
                }             
                if(countYes > 0 && countNot >0) 
                {
                    return StatusCode((int)HttpStatusCode.Created, null/*um modelo que diz quandos foram criados, quantos não puderam ser criados, e os dados dos respectivos não criados*/);
                }
                if (countYes < 0 && countNot > 0)
                    return BadRequest();

                return StatusCode((int)HttpStatusCode.Created);            
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Products user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _productsServices.Put(user);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _productsServices.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
