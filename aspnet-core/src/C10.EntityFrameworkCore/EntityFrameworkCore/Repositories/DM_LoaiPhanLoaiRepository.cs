using Abp.EntityFrameworkCore;
using C10.Domain.DanhMuc.DM_HocVan;
using C10.Core.DanhMuc.DM_LoaiPhanLoai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LoaiPhanLoaiRepository : C10RepositoryBase<DM_LoaiPhanLoai, int>, IDM_LoaiPhanLoaiRepository
    {
        public DM_LoaiPhanLoaiRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LoaiPhanLoai>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
