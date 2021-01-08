/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ModelEffectiveDetailController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Effective.IServices;
namespace VOL.Effective.Controllers
{
    [Route("api/ModelEffectiveDetail")]
    [PermissionTable(Name = "ModelEffectiveDetail")]
    public partial class ModelEffectiveDetailController : ApiBaseController<IModelEffectiveDetailService>
    {
        public ModelEffectiveDetailController(IModelEffectiveDetailService service)
        : base(service)
        {
        }
    }
}

