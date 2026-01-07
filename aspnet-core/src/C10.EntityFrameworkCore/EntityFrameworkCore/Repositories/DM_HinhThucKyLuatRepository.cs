using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_HinhThucKyLuat;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HinhThucKyLuatRepository : C10RepositoryBase<DM_HinhThucKyLuat, int>, IDM_HinhThucKyLuatRepository
    {
        public DM_HinhThucKyLuatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_HinhThucKyLuat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
