using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKyLuat;   
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoKyLuatRepository : MasterDataRepositoryBase<DM_LyDoKyLuat, int>, IDM_LyDoKyLuatRepository
    {
        public DM_LyDoKyLuatRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoKyLuat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
