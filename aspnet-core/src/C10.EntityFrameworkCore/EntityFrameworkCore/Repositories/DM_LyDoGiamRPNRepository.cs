using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LyDoGiamRPN;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoGiamRPNRepository : C10RepositoryBase<DM_LyDoGiamRPN, int>, IDM_LyDoGiamRPNRepository
    {
        public DM_LyDoGiamRPNRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoGiamRPN>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
