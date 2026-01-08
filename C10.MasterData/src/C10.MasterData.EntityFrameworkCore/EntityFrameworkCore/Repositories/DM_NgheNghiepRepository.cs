using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_NgheNghiep;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_NgheNghiepRepository : MasterDataRepositoryBase<DM_NgheNghiep, int>, IDM_NgheNghiepRepository
    {
        public DM_NgheNghiepRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_NgheNghiep>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
