using Abp.EntityFrameworkCore;
using C10.Domain.DanhMuc.DM_LyDoKhongXetGiam;
using C10.Core.DanhMuc.DM_QuanHeVoiPN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10.EntityFrameworkCore.Repositories
{
    public class DM_QuanHeVoiPNRepository : C10RepositoryBase<DM_QuanHeVoiPN, int>, IDM_QuanHeVoiPNRepository
    {
        public DM_QuanHeVoiPNRepository(IDbContextProvider<C10DbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public Task<IEnumerable<DM_QuanHeVoiPN>> Getspecial(string[] pars)
        {
            throw new NotImplementedException();
        }
    }
}
