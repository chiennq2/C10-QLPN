using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_CapToaXu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_CapToaXuRepository : C10RepositoryBase<DM_CapToaXu, int>, IDM_CapToaXuRepository
    {
        public DM_CapToaXuRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_CapToaXu>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
