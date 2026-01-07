using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_DanToc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_DanTocRepository : C10RepositoryBase<DM_DanToc, int>, IDM_DanTocRepository
    {
        public DM_DanTocRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_DanToc>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
