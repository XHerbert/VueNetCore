using JA.Entity.RequestModel;
using JA.Entity.ResponseModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MicrosoftSystemIO = System.IO;
using System.Linq;
using System.Threading.Tasks;
using JA.Core.Services;
using System.IO;

namespace JA.WebApi.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Consumes("application/json", "multipart/form-data")]
    [Route("api/customPay")]
    public class CustomPayController : Controller
    {
        [HttpPost]
        [Route("PayRentFee")]
        public IActionResult PayRentFee([FromBody] CustomPayRequest customPayRequest)
        {

            return Json(new BaseResponse { STATUS = 1, MESSAGE = "缴费成功" });
        }

        [HttpGet]
        [Route("Query")]
        public IActionResult QueryRentFee([FromBody] CustomRequest customRequest)
        {
            return Json(new BaseResponse { STATUS = 1, MESSAGE = "成功" });
        }

        [HttpPost]
        [Route("Transfer")]
        public IActionResult PostText([FromForm] IFormCollection keyValuePairs)
        {
            try
            {
                FormFileCollection formFiles = (FormFileCollection)keyValuePairs.Files;
                FormFile file = (FormFile)formFiles[0];
                StreamReader reader = new StreamReader(formFiles[0].OpenReadStream());
                string content = reader.ReadToEnd();
                Logger.Info(content);
                string name = file.FileName;
                string fileName = Path.Combine(@"Upload", name);
                using (FileStream fs = MicrosoftSystemIO.File.Create(fileName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                //TODO:针对对账文件的读取与处理
                return Content("upload and save success!");
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return Content("upload failed!");
            }
        }
    }
}
