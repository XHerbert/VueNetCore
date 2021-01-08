/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ProjectListController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Project.IServices;
namespace VOL.Project.Controllers
{
    [Route("api/ProjectList")]
    [PermissionTable(Name = "ProjectList")]
    public partial class ProjectListController : ApiBaseController<IProjectListService>
    {
        public ProjectListController(IProjectListService service)
        : base(service)
        {
        }
    }
}

