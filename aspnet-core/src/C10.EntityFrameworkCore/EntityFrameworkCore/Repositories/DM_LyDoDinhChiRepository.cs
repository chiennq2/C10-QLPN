using Abp.EntityFrameworkCore;
using C10.Core.DanhMuc.DM_LyDoDinhChi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_LyDoDinhChiRepository : C10RepositoryBase<DM_LyDoDinhChi, int>, IDM_LyDoDinhChiRepository
    {
        public DM_LyDoDinhChiRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<IEnumerable<DM_LyDoDinhChi>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
