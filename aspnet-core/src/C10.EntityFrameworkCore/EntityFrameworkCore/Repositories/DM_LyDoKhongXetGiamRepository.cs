using Abp.EntityFrameworkCore;
using C10.Domain.DanhMuc.DM_DanToc;
using C10.Core.DanhMuc.DM_LyDoKhongXetGiam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoKhongXetGiamRepository : C10RepositoryBase<DM_LyDoKhongXetGiam, int>, IDM_LyDoKhongXetGiamRepository
    {
        public DM_LyDoKhongXetGiamRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_LyDoKhongXetGiam>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
