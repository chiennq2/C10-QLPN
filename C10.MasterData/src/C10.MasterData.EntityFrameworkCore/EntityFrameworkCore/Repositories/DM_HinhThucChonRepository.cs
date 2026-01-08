using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucChon;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HinhThucChonRepository : MasterDataRepositoryBase<DM_HinhThucChon, int>, IDM_HinhThucChonRepository
    {
        public DM_HinhThucChonRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider) { }
        public Task<IEnumerable<DM_HinhThucChon>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
