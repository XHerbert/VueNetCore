/*
 *Author：xuhbd
 *Contact：xuhb-c@glodon.com
 *接口编写处...
 *如果接口需要做Action的权限验证，请在Action上使用属性
 *如: [ApiActionPermission("Department",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using JA.Entity.DomainModels;
using JA.Business.IServices;

namespace JA.Business.Controllers
{
    public partial class DepartmentController
    {
        private readonly IDepartmentService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public DepartmentController(
            IDepartmentService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
