/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下ProjectListService与IProjectListService中编写
 */
using VOL.Project.IRepositories;
using VOL.Project.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Project.Services
{
    public partial class ProjectListService : ServiceBase<ProjectList, IProjectListRepository>
    , IProjectListService, IDependency
    {
    public ProjectListService(IProjectListRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IProjectListService Instance
    {
      get { return AutofacContainerModule.GetService<IProjectListService>(); } }
    }
 }
