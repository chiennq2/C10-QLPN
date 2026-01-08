using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_HocVan;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HocVanRepository : MasterDataRepositoryBase<DM_HocVan, int>, IDM_HocVanRepository
    {
        public DM_HocVanRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_HocVan>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
