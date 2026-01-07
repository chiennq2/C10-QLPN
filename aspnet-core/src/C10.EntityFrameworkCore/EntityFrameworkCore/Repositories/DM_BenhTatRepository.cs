using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_BenhTat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_BenhTatRepository : C10RepositoryBase<DM_BenhTat, int> , IDM_BenhTatRepository
    {
        public DM_BenhTatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_BenhTat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
