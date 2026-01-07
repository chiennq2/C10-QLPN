using Abp.EntityFrameworkCore;
using C10.Domain.DanhMuc.DM_MaPhanLoai;
using C10.Core.DanhMuc.DM_NgheNghiep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_NgheNghiepRepository : C10RepositoryBase<DM_NgheNghiep, int>, IDM_NgheNghiepRepository
    {
        public DM_NgheNghiepRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_NgheNghiep>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
