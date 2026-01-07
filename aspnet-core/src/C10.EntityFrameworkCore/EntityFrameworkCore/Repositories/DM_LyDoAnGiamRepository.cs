using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LyDoAnGiam;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoAnGiamRepository : C10RepositoryBase<DM_LyDoAnGiam, int>, IDM_LyDoAnGiamRepository
    {
        public DM_LyDoAnGiamRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoAnGiam>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
