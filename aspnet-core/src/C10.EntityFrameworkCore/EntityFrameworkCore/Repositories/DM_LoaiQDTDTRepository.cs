using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LoaiQDTDT;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LoaiQDTDTRepository : C10RepositoryBase<DM_LoaiQDTDT, int>, IDM_LoaiQDTDTRepository
    {
        public DM_LoaiQDTDTRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LoaiQDTDT>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
