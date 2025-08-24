using eCommerce.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebApi.Controllers;

[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] Product product)
    {
        return CreatedAtAction();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProduct([FromBody] Product product)
    {
        return CreatedAtAction();
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateProduct([FromBody] Product product)
    {
        return CreatedAtAction();
    }

    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
    {
        return CreatedAtAction();
    }
}