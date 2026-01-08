using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_HinhThucKyLuat;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HinhThucKyLuatRepository : MasterDataRepositoryBase<DM_HinhThucKyLuat, int>, IDM_HinhThucKyLuatRepository
    {
        public DM_HinhThucKyLuatRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_HinhThucKyLuat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
