using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_HinhPhatBoSung;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HinhPhatBoSungRepository : MasterDataRepositoryBase<DM_HinhPhatBoSung, int>, IDM_HinhPhatBoSungRepository
    {
        public DM_HinhPhatBoSungRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider) { }
        public Task<IEnumerable<DM_HinhPhatBoSung>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
