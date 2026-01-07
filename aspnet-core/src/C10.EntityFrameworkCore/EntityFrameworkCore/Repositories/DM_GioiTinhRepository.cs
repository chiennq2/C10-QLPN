using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_GioiTinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_GioiTinhRepository : C10RepositoryBase<DM_GioiTinh, int>, IDM_GioiTinhRepository
    {
        public DM_GioiTinhRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        public Task<IEnumerable<DM_GioiTinh>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
