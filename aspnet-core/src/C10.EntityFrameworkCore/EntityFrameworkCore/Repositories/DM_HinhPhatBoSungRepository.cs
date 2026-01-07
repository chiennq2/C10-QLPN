using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_HinhPhatBoSung;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HinhPhatBoSungRepository : C10RepositoryBase<DM_HinhPhatBoSung, int>, IDM_HinhPhatBoSungRepository
    {
        public DM_HinhPhatBoSungRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider) { }
        public Task<IEnumerable<DM_HinhPhatBoSung>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
