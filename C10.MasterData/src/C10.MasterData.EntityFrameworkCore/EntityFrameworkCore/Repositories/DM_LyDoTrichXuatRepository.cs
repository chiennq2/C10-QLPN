using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LyDoTrichXuat;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoTrichXuatRepository : MasterDataRepositoryBase<DM_LyDoTrichXuat, int>, IDM_LyDoTrichXuatRepository
    {
        public DM_LyDoTrichXuatRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoTrichXuat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
