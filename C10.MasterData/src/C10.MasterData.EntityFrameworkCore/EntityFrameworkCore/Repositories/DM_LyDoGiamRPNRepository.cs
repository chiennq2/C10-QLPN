using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LyDoGiamRPN;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoGiamRPNRepository : MasterDataRepositoryBase<DM_LyDoGiamRPN, int>, IDM_LyDoGiamRPNRepository
    {
        public DM_LyDoGiamRPNRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoGiamRPN>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
