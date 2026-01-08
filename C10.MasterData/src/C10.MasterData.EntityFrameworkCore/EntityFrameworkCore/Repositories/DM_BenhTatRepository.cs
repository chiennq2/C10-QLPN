using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_BenhTat;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_BenhTatRepository : MasterDataRepositoryBase<DM_BenhTat, int> , IDM_BenhTatRepository
    {
        public DM_BenhTatRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_BenhTat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
