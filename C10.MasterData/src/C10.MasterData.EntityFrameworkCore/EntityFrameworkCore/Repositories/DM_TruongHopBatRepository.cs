using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_TruongHopBat;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_TruongHopBatRepository : MasterDataRepositoryBase<DM_TruongHopBat, int>, IDM_TruongHopBatRepository
    {
        public DM_TruongHopBatRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_TruongHopBat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
