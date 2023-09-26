using Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    List<ProductoViewModel> productos;

    public UsuarioController()
    {
        productos = new List<ProductoViewModel>();

        productos.Add(new ProductoViewModel() { Nombre = "Aceite", Descripcion = "Marolio" });
        productos.Add(new ProductoViewModel() { Nombre = "Arroz", Descripcion = "Dos Hermanos" });
        productos.Add(new ProductoViewModel() { Nombre = "Dulce de leche", Descripcion = "La Serenisima" });
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(productos);
    }

    [HttpPost]
    public ActionResult Post(ProductoViewModel producto)
    {
        productos.Add(producto);
        return Ok(productos);
    }

    [HttpPut]
    public ActionResult Put(int idProducto, ProductoViewModel producto)
    {
        return Ok("Producto actualizado");
    }

    [HttpDelete]
    public ActionResult Delete(int idProducto)
    {
        return Ok("Producto eliminado");
    }
}