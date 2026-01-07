using Abp.EntityFrameworkCore;
using C10.Domain.DanhMuc.DM_LyDoTrichXuat;
using C10.Core.DanhMuc.DM_MaPhanLoai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_MaPhanLoaiRepository : C10RepositoryBase<DM_MaPhanLoai, int>, IDM_MaPhanLoaiRepository
    {
        public DM_MaPhanLoaiRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_MaPhanLoai>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
