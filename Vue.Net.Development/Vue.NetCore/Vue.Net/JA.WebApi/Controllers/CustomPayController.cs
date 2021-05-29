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
using Newtonsoft.Json;

namespace JA.WebApi.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [Consumes("application/json", "multipart/form-data")]
    [Route("api/customPay")]
    public class CustomPayController : Controller
    {
        /// <summary>
        /// 缴费接口
        /// </summary>
        /// <param name="customPayRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PayRentFee")]
        public IActionResult PayRentFee([FromBody] CustomPayRequest customPayRequest)
        {
            Logger.Info(Core.Enums.LoggerType.Info, JsonConvert.SerializeObject(customPayRequest));
            return Json(new BaseResponse { STATUS = 1, MESSAGE = "缴费成功" });
        }

        /// <summary>
        /// 查询接口
        /// </summary>
        /// <param name="customRequest">客户ID号</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Query")]
        public IActionResult QueryRentFee([FromBody] CustomRequest customRequest)
        {
            Logger.Info(Core.Enums.LoggerType.Info, JsonConvert.SerializeObject(customRequest));
            return Json(new BaseResponse { STATUS = 1, MESSAGE = "成功" });
        }

        /// <summary>
        /// 对账文件上传
        /// </summary>
        /// <param name="keyValuePairs"></param>
        /// <returns></returns>
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
