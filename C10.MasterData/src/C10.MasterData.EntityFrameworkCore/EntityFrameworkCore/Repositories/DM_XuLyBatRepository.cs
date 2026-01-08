using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_XuLyBat;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_XuLyBatRepository : MasterDataRepositoryBase<DM_XuLyBat, int>, IDM_XuLyBatRepository
    {
        public DM_XuLyBatRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_XuLyBat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
