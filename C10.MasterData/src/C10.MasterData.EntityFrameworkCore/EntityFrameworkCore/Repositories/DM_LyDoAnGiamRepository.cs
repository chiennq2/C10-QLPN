using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LyDoAnGiam;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoAnGiamRepository : MasterDataRepositoryBase<DM_LyDoAnGiam, int>, IDM_LyDoAnGiamRepository
    {
        public DM_LyDoAnGiamRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoAnGiam>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
