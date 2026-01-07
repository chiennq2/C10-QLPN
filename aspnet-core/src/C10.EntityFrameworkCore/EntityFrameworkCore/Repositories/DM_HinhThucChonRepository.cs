using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_HinhThucChon;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HinhThucChonRepository : C10RepositoryBase<DM_HinhThucChon, int>, IDM_HinhThucChonRepository
    {
        public DM_HinhThucChonRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider) { }
        public Task<IEnumerable<DM_HinhThucChon>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
