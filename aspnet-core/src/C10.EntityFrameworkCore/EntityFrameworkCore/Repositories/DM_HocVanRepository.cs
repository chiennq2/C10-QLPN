using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_HocVan;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HocVanRepository : C10RepositoryBase<DM_HocVan, int>, IDM_HocVanRepository
    {
        public DM_HocVanRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_HocVan>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
