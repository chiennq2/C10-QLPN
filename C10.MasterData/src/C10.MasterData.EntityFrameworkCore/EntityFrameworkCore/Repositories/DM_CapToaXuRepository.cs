using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_CapToaXu;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_CapToaXuRepository : MasterDataRepositoryBase<DM_CapToaXu, int>, IDM_CapToaXuRepository
    {
        public DM_CapToaXuRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_CapToaXu>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
