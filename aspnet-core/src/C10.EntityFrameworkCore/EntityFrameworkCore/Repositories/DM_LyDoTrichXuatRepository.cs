using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LyDoTrichXuat;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoTrichXuatRepository : C10RepositoryBase<DM_LyDoTrichXuat, int>, IDM_LyDoTrichXuatRepository
    {
        public DM_LyDoTrichXuatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoTrichXuat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
