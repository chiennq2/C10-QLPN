using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_GhiChuRieng;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_GhiChuRiengRepository : MasterDataRepositoryBase<DM_GhiChuRieng, int>, IDM_GhiChuRiengRepository
    {
        public DM_GhiChuRiengRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }


        public Task<IEnumerable<DM_GhiChuRieng>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
