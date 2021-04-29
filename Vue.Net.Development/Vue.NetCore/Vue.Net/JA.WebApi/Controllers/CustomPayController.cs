using JA.Entity.RequestModel;
using JA.Entity.ResponseModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JA.WebApi.Controllers
{
    [AllowAnonymous]
    
    [Route("api/customPay")]
    public class CustomPayController : Controller
    {
        [HttpPost]
        public IActionResult PayRentFee([FromBody] CustomPayRequest customPayRequest)
        {

            return Json(new BaseResponse { STATUS = 1, MESSAGE = "成功" });
        }

        [HttpGet]
        public IActionResult QueryRentFee([FromBody] CustomRequest customRequest)
        {
            return Json(new BaseResponse { STATUS = 1, MESSAGE = "成功" });
        }
    }
}
