using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKhen;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoKhenRepository : MasterDataRepositoryBase<DM_LyDoKhen, int>, IDM_LyDoKhenRepository
    {
        public DM_LyDoKhenRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoKhen>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
