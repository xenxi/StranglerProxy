﻿using Microsoft.AspNetCore.Mvc;

namespace ProxyApi.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("test")]
        [HttpGet]
        public IActionResult Test()
        {
            return Ok(new { OverrideController = true });
        }

        [Route("test1/{argument}")]
        [HttpGet]
        public IActionResult Test1(string argument)
        {
            return Ok(new { OverrideController = true, Argument = argument });
        }

        [Route("test4")]
        [HttpPost]
        public IActionResult Test4(object dto)
        {
            return Ok(new { OverrideController = true, Argument = dto });
        }

        [Route("test6")]
        [HttpPut]
        public IActionResult Test6(object dto)
        {
            return Ok(new { OverrideController = true, Argument = dto });
        }

        [Route("test8/{argument}")]
        [HttpDelete]
        public IActionResult Test7(string argument)
        {
            return Ok(new { OverrideController = true, Argument = argument });
        }
    }
}