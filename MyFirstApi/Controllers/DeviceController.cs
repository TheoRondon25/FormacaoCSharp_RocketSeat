using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;

// herda de MyFirstApiBaseController para herdar as configurações do controller base
public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var laptop = new Laptop();

        var model = laptop.GetBrand();

        return Ok(model);
    }

}


