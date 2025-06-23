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
        var key = GetCustomKey();

        return Ok(key);
    }

}


