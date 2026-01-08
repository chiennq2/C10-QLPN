using Abp.EntityFrameworkCore;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQuyetDinhTrichXuat;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LoaiQuyetDinhTrichXuatRepository : MasterDataRepositoryBase<DM_LoaiQuyetDinhTrichXuat, int>, IDM_LoaiQuyetDinhTrichXuatRepository
    {
        public DM_LoaiQuyetDinhTrichXuatRepository(IDbContextProvider<MasterDataDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LoaiQuyetDinhTrichXuat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
