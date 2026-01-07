using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LyDoKhen;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoKhenRepository : C10RepositoryBase<DM_LyDoKhen, int>, IDM_LyDoKhenRepository
    {
        public DM_LyDoKhenRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoKhen>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
