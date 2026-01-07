using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_GhiChuRieng;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_GhiChuRiengRepository : C10RepositoryBase<DM_GhiChuRieng, int>, IDM_GhiChuRiengRepository
    {
        public DM_GhiChuRiengRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }


        public Task<IEnumerable<DM_GhiChuRieng>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
