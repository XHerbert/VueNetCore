/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下MainModelService与IMainModelService中编写
 */
using VOL.Effective.IRepositories;
using VOL.Effective.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Effective.Services
{
    public partial class MainModelService : ServiceBase<MainModel, IMainModelRepository>
    , IMainModelService, IDependency
    {
    public MainModelService(IMainModelRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IMainModelService Instance
    {
      get { return AutofacContainerModule.GetService<IMainModelService>(); } }
    }
 }
