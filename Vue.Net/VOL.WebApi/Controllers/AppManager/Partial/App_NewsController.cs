/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("App_News",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;
using VOL.AppManager.IRepositories;
using VOL.AppManager.IServices;
using VOL.AppManager.Services;
using VOL.Core.CacheManager;
using VOL.Core.Enums;
using VOL.Core.Filters;
using VOL.Entity.DomainModels;

namespace VOL.AppManager.Controllers
{
    [Route("api/news")]
    public partial class App_NewsController
    {
        private readonly IApp_NewsService _newsService;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IApp_NewsRepository _newsRepository;//访问数据库
        private readonly ICacheService _cacheService;


        /// <summary>
        /// Controller中使用构造方法注入
        ///  : base(userService)给父类传递当前service必须要有
        /// </summary>
        /// <param name="userService"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="userRepository"></param>
        /// <param name="cacheService"></param>
        [ActivatorUtilitiesConstructor]
        public App_NewsController(
            IApp_NewsService newsService,
            IHttpContextAccessor httpContextAccessor,
            IApp_NewsRepository newsRepository,
            ICacheService cacheService
            )
        : base(newsService)
        {
            _newsService = newsService;
            _httpContextAccessor = httpContextAccessor;
            _newsRepository = newsRepository;
            _cacheService = cacheService;
        }

        /// <summary>
        /// 生成静态页面
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        [HttpPost, Route("createPage")]
        [ApiActionPermission("App_News", ActionPermissionOptions.Add)]
        public async Task<IActionResult> CreatePage([FromBody] App_News news)
        {
            return Json(await Service.CreatePage(news));
        }
        /// <summary>
        /// 设置封面图片
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        [ApiActionPermission("App_News", ActionPermissionOptions.Add)]
        [HttpPost, Route("setCover")]

        public IActionResult SetCover([FromBody] App_News news, string t1, string t2)
        {
            return Json(Service.SetCover(news));
        }
        /// <summary>
        /// 设置封面图片
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        [ApiActionPermission("App_News", ActionPermissionOptions.Search)]
        [HttpPost, Route("getDemoPageList")]
        public async Task<IActionResult> GetDemoPageList()
        {
            return Json(await Service.GetDemoPageList());
        }


        /// <summary>
        /// 更新浏览次数
        /// </summary>
        /// <param name="appNews"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost, Route("updateViewCount")]
        public async Task<IActionResult> UpdateViewCount([FromBody] App_News appNews)
        {
            List<App_News> appNewsList = new List<App_News>();
            appNewsList.Add(appNews);
            //更新部分字段
            _newsRepository.UpdateRange(appNewsList, x => new { x.ViewCount });
            await _newsRepository.DbContext.SaveChangesAsync();
            return Json(new { msg = "update success" });
        }

        /// <summary>
        /// 获取最新浏览量
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet, Route("getViewCount")]
        public async Task<IActionResult> getViewCount(int id)
        {
            App_News app_News = await _newsRepository.FindAsyncFirst<App_News>(news => news.Id == id);
            return Json( new { count = app_News.ViewCount });
        }
    }
}
