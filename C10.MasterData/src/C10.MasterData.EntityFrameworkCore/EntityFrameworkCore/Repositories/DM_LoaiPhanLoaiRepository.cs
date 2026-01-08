using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LoaiPhanLoai;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LoaiPhanLoaiRepository : MasterDataRepositoryBase<DM_LoaiPhanLoai, int>, IDM_LoaiPhanLoaiRepository
    {
        public DM_LoaiPhanLoaiRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LoaiPhanLoai>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
