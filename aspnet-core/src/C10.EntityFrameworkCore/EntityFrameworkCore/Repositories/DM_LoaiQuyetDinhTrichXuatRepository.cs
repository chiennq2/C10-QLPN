using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LoaiQuyetDinhTrichXuat;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LoaiQuyetDinhTrichXuatRepository : C10RepositoryBase<DM_LoaiQuyetDinhTrichXuat, int>, IDM_LoaiQuyetDinhTrichXuatRepository
    {
        public DM_LoaiQuyetDinhTrichXuatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LoaiQuyetDinhTrichXuat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
