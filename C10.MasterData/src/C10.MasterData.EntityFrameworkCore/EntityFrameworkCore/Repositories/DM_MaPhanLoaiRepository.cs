using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_MaPhanLoai;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_MaPhanLoaiRepository : MasterDataRepositoryBase<DM_MaPhanLoai, int>, IDM_MaPhanLoaiRepository
    {
        public DM_MaPhanLoaiRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_MaPhanLoai>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
