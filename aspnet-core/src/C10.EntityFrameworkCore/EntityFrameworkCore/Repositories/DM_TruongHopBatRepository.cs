using Abp.EntityFrameworkCore;
using C10.Domain.DanhMuc.DM_QuocTich;
using C10.Core.DanhMuc.DM_TruongHopBat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_TruongHopBatRepository : C10RepositoryBase<DM_TruongHopBat, int>, IDM_TruongHopBatRepository
    {
        public DM_TruongHopBatRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_TruongHopBat>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
