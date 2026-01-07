using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LyDoKyLuat;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoKyLuatRepository : C10RepositoryBase<DM_LyDoKyLuat, int>, IDM_LyDoKyLuatRepository
    {
        public DM_LyDoKyLuatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoKyLuat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
