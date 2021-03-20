﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JA.Core.BaseProvider;
using JA.Entity.DomainModels;
using JA.Core.Extensions.AutofacManager;
namespace JA.Builder.IRepositories
{
    public partial interface ISys_TableInfoRepository : IDependency,IRepository<Sys_TableInfo>
    {
    }
}

