using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKhongXetGiam;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoKhongXetGiamRepository : MasterDataRepositoryBase<DM_LyDoKhongXetGiam, int>, IDM_LyDoKhongXetGiamRepository
    {
        public DM_LyDoKhongXetGiamRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_LyDoKhongXetGiam>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
