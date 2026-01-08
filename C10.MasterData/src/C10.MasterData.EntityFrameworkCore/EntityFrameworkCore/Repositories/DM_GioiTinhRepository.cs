using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_GioiTinh;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_GioiTinhRepository : MasterDataRepositoryBase<DM_GioiTinh, int>, IDM_GioiTinhRepository
    {
        public DM_GioiTinhRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        public Task<IEnumerable<DM_GioiTinh>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
