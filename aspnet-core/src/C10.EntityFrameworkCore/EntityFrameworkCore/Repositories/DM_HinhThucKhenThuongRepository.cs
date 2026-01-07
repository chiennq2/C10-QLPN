using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_HinhThucKhenThuong;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_HinhThucKhenThuongRepository : C10RepositoryBase<DM_HinhThucKhenThuong, int>, IDM_HinhThucKhenThuongRepository
    {
        public DM_HinhThucKhenThuongRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_HinhThucKhenThuong>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
