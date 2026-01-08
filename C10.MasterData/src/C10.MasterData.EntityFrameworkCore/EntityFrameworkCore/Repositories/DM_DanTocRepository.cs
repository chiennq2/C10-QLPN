using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_DanToc;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_DanTocRepository : MasterDataRepositoryBase<DM_DanToc, int>, IDM_DanTocRepository
    {
        public DM_DanTocRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_DanToc>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
