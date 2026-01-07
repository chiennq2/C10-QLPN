using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_XuLyBat;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_XuLyBatRepository : C10RepositoryBase<DM_XuLyBat, int>, IDM_XuLyBatRepository
    {
        public DM_XuLyBatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_XuLyBat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
