﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMusicStore.Data.Context.Interfaces
{
    public interface IContextManager<TContext>
       where TContext : IDbContext, new()
    {
        IDbContext GetContext();
        void Finish();
    }
}
