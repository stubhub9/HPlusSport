using HPlusSport.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace HPlusSport.API.Controllers
{
    [Route ( "api/[controller]" )]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController (ShopContext context )
        {
            _context = context;
            _context.Database.EnsureCreated ();
        }


        //        [HttpGet("{id}")]
        //        public ActionResult<IEnumerable<Product>> GetAllProducts ()
        [HttpGet]
        public async Task<ActionResult> GetAllProducts ()
        {
            return Ok(await _context.Products.ToArrayAsync());
        }



        [HttpGet ( "{id}" )]
        public async Task<ActionResult> GetProduct (int id)
        {
            var product = await _context.Products.FindAsync ( id );
            if (product == null)
            {
                return NotFound ();
            }

            return Ok ( product );
        }

        [HttpGet("available")]
        public async  Task<ActionResult<IEnumerable<Product>>> GetAvailableProducts()
        {
            return await _context.Products.Where(p => p.IsAvailable).ToArrayAsync();
        }

        [HttpPost]
        public async Task<ActionResult> PostProduct ( Product product )
        {
            //  AspNc.Mvc.ModelBinding.ModelStateDictContBase
            if (!ModelState.IsValid)
            {
                return BadRequest ();
            }

            _context.Products.Add ( product );
            await _context.SaveChangesAsync ();

            return CreatedAtAction (
                nameof ( GetProduct ),
                new { id = product.Id },
                product );
        }

        [HttpPut ( "{id}" )]
        public async Task<ActionResult> PutProduct ( int id, Product product )
        {
            //  If modified product doesn't match original id
            if (id != product.Id)
            {
                return BadRequest ();
            }

            _context.Entry ( product ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync ();
            }
            //  If product was deleted before put update  error404
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any ( p => p.Id == id ))
                {
                    return NotFound ();
                }
                else
                {
                    //  Error 500
                    throw;
                }
            }
            //  No problems, so Ok, but nothing to see here.
            return NoContent ();
        }


        [HttpDelete ( "{id}" )]
        //  [FromRoute] being optional here, but good practice 
        public async Task<ActionResult> DeleteProduct ([FromRoute]int id)
        {
            var product = await _context.Products.FindAsync (id);
            if (product == null)
            {
                return NotFound ();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync ();

            return Ok ( product );
        }




    }
}
