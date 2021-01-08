/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹SellBaController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Order.IServices;
namespace VOL.Order.Controllers
{
    [Route("api/SellBa")]
    [PermissionTable(Name = "SellBa")]
    public partial class SellBaController : ApiBaseController<ISellBaService>
    {
        public SellBaController(ISellBaService service)
        : base(service)
        {
        }
    }
}

