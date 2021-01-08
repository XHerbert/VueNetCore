/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹MainModelController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Effective.IServices;
namespace VOL.Effective.Controllers
{
    [Route("api/MainModel")]
    [PermissionTable(Name = "MainModel")]
    public partial class MainModelController : ApiBaseController<IMainModelService>
    {
        public MainModelController(IMainModelService service)
        : base(service)
        {
        }
    }
}

